using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using IronPython.Hosting;
using Communicator;
using Microsoft.Scripting.Hosting;
using Newtonsoft.Json;
using KalutClient.Objects;

namespace KalutClient
{
    public partial class WallViewHost : MetroForm
    {
        private int UID;
        private int PIN;
        private int QuestionIndex = 0;
        private string MyStatus;
        ScriptRuntime IronPython;
        bool GameStarted = false;
        dynamic IronPythonScript;
        WelcomeScreen parent;
        WaitForPlayersView waitView;
        WallAnswerView ansView;
        KalutQuestion[] quizData;
        public WallViewHost(int KalutUID, WelcomeScreen parent)
        {
            IronPython = Python.CreateRuntime();
            IronPythonScript = IronPython.UseFile("conn.py");
            UID = KalutUID;
            this.parent = parent;
            InitializeComponent();
            waitView = new WaitForPlayersView(this);
            Controls.Add(waitView);
            waitView.Hide();
            ansView = new WallAnswerView(this);
            ansView.Dock = DockStyle.Fill;
        }
        private async Task LoadQuiz()
        {
            await Task.Delay(50);
            var worker = Communicator.Communicator.GetQuizDataByUID(UID);
            await worker.ContinueWith(t =>
            {
                quizData = JsonConvert.DeserializeObject<KalutQuestion[]>(t.Result["Quiz"]);
            },
            TaskScheduler.FromCurrentSynchronizationContext());
        }
        private async void WallViewHost_Load(object sender, EventArgs e)
        {
            status_lbl.Text = "Creating room...";
            await Task.Delay(1000);
            CreateRoom();
        }

        private void CreateRoom()
        {
            var worker = Communicator.Communicator.CreateRoom(UID);
            worker.ContinueWith(async t =>
            {
                PIN = int.Parse(t.Result["pin"]);
                status_lbl.Text ="Connecting...";
                await Task.Delay(1000);
                Connect();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private async void Connect()
        {
            IronPythonScript.setup();
            string connected = IronPythonScript.connect("@#@WALLVIEW@#@", PIN);
            var data = JsonConvert.DeserializeObject<Dictionary<string, string>>(connected);
            if (data["status"] == "ok")
            {
                if (!data.Keys.Contains("UID"))
                {
                    IronPythonScript.close();
                    parent.Show();
                    Close();
                    return;
                }
                UID = int.Parse(data["UID"]);
                await LoadQuiz();
                status_lbl.Text = "Connected!";
                status_spn.Spinning = false;
                status_spn.Value = 100;
                waitView.pin_lbl.Text = PIN.ToString();
                waitView.Show();
                waitView.BringToFront();
                waitView.Dock = DockStyle.Fill;
                MyStatus = "WAITING_FOR_PLAYERS";
                timer1.Start();
            }
            else
                status_lbl.Text = string.Format("Not connected! (PIN={0})", PIN);
        }

        private void metroProgressSpinner1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("timer tick" + MyStatus);
            string strdata = IronPythonScript.get_list_of_players();
            Dictionary<string, string> data= JsonConvert.DeserializeObject<Dictionary<string,string>>(
                strdata);
            if (data.Keys.Contains("status"))
            {
                if (data["status"] == "eog")
                {
                    string winner = "";
                    if (data.Keys.Contains("winner"))
                        winner += data["winner"];
                    timer1.Stop();
                    IronPythonScript.close();
                    parent.Show();
                    Close();
                    return;
                }
                else if (data["status"] == "socket closed")
                {
                    timer1.Stop();
                    parent.Show();
                    Close();
                    return;
                }
            }
            if (data["game_status"]== "WAITING_FOR_PLAYERS" || data["game_status"] == "WAITING_FOR_LAST_PLAYER" || data["game_status"] == "WAITING_FOR_LAST_PLAYER_SYNC")
            {
                string[] plist = JsonConvert.DeserializeObject<string[]>(data["players"]);
                string plist_str = "";
                foreach (string item in plist)
                {
                    plist_str += item + "    ";
                }
                waitView.playesr_txt.Text = plist_str;
            }
            else
            {
                if (!GameStarted)
                {
                    ansView.nextq_btn.Enabled = true;
                    ansView.nextq_btn.BringToFront();
                    GameStarted = true;
                    waitView.Hide();
                    Controls.Add(ansView);
                    ansView.BringToFront();
                }
                ansView.Update(quizData[int.Parse(data["onq"])]);
            }
        }
        internal void StartButtonClick()
        {
            ansView.nextq_btn.Enabled = true;
            GameStarted = true;
            waitView.Hide();
            Controls.Add(ansView);
            ansView.BringToFront();
            NextButtonClick();
        }
        internal void NextButtonClick()
        {
            ansView.ResetAnsTiles();
            Dictionary<string, string> data = JsonConvert.DeserializeObject<Dictionary<string, string>>(
                IronPythonScript.wallview_next_q());
            if (data.Keys.Contains("status"))
                if (data["status"]=="socket closed")
                {
                    timer1.Stop();
                    parent.Show();
                    Close();
                    return;
                }
        }
    }
}
