using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using Newtonsoft.Json;
using KalutClient.Objects;
using Communicator;

namespace KalutClient
{
    public partial class PlayerViewHost : MetroForm
    {
        AnsweredView AnsweredView;
        JoinKalutView joinview;
        AnswerQuestionView QuestionView;
        private int UID;
        private int PIN;
        private KalutQuestion[] QuizData;
        private string name;
        ScriptRuntime IronPython;
        dynamic IronPythonScript;
        private int SelectedAnswer = -1;
        private int SelectedAnswerTime = -1;
        private bool GameStarted = false;
        WelcomeScreen parent;
        public PlayerViewHost(WelcomeScreen parent)
        {
            InitializeComponent();
            this.parent = parent;
            joinview = new JoinKalutView(this);
            QuestionView = new AnswerQuestionView(this);
            AnsweredView = new AnsweredView(this);
            AnsweredView.Dock = DockStyle.Fill;
            Controls.Add(AnsweredView);
            Controls.Add(QuestionView);
            QuestionView.Hide();
            AnsweredView.Hide();
            IronPython = Python.CreateRuntime();
            IronPythonScript = IronPython.UseFile("conn.py");
        }

        private void PlayerViewHost_Load(object sender, EventArgs e)
        {
            LoadJoinKalutView();
        }

        internal void JoinKalut_Press()
        {
            DisplayJoinKalutView(false);
            name = joinview.screen_name_txt.Text;
            PIN = (int)joinview.PIN_txt.Value;
            TryConnect();
        }
        private async void TryConnect()
        {
            Text = "Connecting...";
            status_lbl.Text = "Connecting...";
            await Task.Delay(1000);
            IronPythonScript.setup();
            string connected = IronPythonScript.connect(name, PIN);
            var data = JsonConvert.DeserializeObject<Dictionary<string, string>>(connected);
            if (data["status"] == "ok")
            {
                Text = "Kalut Game";
                status_lbl.Text = "Connected! Please wait for the host to start the game...";
                GameStarted = true;
                UID = int.Parse(data["UID"]);
                await LoadQuiz();
                var worker = WaitForServerResponse();
                await worker.ContinueWith(t =>
                 {
                     if (!t.Result.Keys.Contains("ShowQ")) { IronPythonScript.close(); parent.Show(); Close(); }
                     DisplayQuestion(int.Parse(t.Result["ShowQ"]));
                     status_lbl.Text = "Please wait...";
                 }, TaskScheduler.FromCurrentSynchronizationContext());
            }
            else
            {
                Text = "Kalut Client";
                status_lbl.Text = "Not connected!";
                DisplayJoinKalutView(true);
                joinview.err_lbl.Text = data["status"];
            }
                
        }
        private async Task<Dictionary<string, string>> WaitForServerResponse()
        {
            return await Task.Run(() =>
            {
                string data = IronPythonScript.wait_for_server();
                return JsonConvert.DeserializeObject<Dictionary<string, string>>(data);
            });
        }
        private void LoadJoinKalutView()
        {
            Controls.Add(joinview);
            joinview.Show();
            joinview.Dock = DockStyle.Fill;
            joinview.BringToFront();
        }
        private async Task LoadQuiz()
        {
            await Task.Delay(50);
            var worker = Communicator.Communicator.GetQuizDataByUID(UID);
            await worker.ContinueWith(t =>
             {
                 QuizData = JsonConvert.DeserializeObject<KalutQuestion[]>(t.Result["Quiz"]);
             },
            TaskScheduler.FromCurrentSynchronizationContext());
        }
        private void DisplayJoinKalutView(bool display)
        {
            if (display)
            {
                joinview.Show();
                joinview.Dock = DockStyle.Fill;
                joinview.BringToFront();
            }
            else
            {
                joinview.Hide();
            }
        }
        private void DisplayQuestion(int index)
        {
            QuestionView.timeout_spn.Style = MetroFramework.MetroColorStyle.Blue;
            QuestionView.Show();
            QuestionView.BringToFront();
            QuestionView.Update(QuizData[index]);
            QuestionTimeout_timer.Start();
            QuestionView.Dock = DockStyle.Fill;
            Console.WriteLine(index + 1);
        }
        public void Answer(int ans)
        {
            QuestionView.Hide();
            SelectedAnswer = ans;
            SelectedAnswerTime = (int)IronPythonScript.get_time();
        }
        private async void SendAnswer()
        {
            QuestionTimeout_timer.Stop();
            Dictionary<string, string> data = JsonConvert.DeserializeObject<Dictionary<string, string>>(
                IronPythonScript.answer(SelectedAnswer, SelectedAnswerTime));
            if(data.Keys.Contains("status"))
                if (data["status"]=="socket closed")
                {
                    QuestionTimeout_timer.Stop();
                    MessageBox.Show("Game ended.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    return;
                }
            AnsweredView.Show();
            AnsweredView.Update(data["Points"], bool.Parse(data["Correct"]));
            AnsweredView.BringToFront();
            Text = "Results";
            var worker = WaitForServerResponse();
            await worker.ContinueWith(t =>
            {
                AnsweredView.Hide();
                if (t.Result["status"] == "eog")
                {
                    string winner="";
                    if (t.Result.Keys.Contains("winner"))
                        winner += t.Result["winner"];
                    QuestionTimeout_timer.Stop();
                    IronPythonScript.close();
                    MessageBox.Show("Game ended. " + winner, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    return;
                    
                }
                else if (t.Result["status"]=="socket closed")
                {
                    QuestionTimeout_timer.Stop();
                    MessageBox.Show("Game ended.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    return;
                }
                DisplayQuestion(int.Parse(t.Result["ShowQ"]));
                status_lbl.Text = "Please wait...";
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }
        private void QuestionTimeout_timer_Tick(object sender, EventArgs e)
        {
            --QuestionView.timeout_spn.Value;
            if (QuestionView.timeout_spn.Value < 6)
                QuestionView.timeout_spn.Style = MetroFramework.MetroColorStyle.Red;
            QuestionView.timeout_txt.Text = (int.Parse(QuestionView.timeout_txt.Text) - 1).ToString();
            if(QuestionView.timeout_spn.Value == 0)
            {
                if (SelectedAnswer == -1)
                    Answer(SelectedAnswer);
                SendAnswer();
            }
        }

        private void PlayerViewHost_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GameStarted)
            {
                QuestionTimeout_timer.Stop();
                IronPythonScript.close();
            }
            parent.Show();
        }

        private void status_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
