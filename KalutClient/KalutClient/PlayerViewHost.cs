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
        JoinKalutView joinview;
        private int UID;
        private int PIN;
        private KalutQuestion[] QuizData;
        private string name;
        ScriptRuntime IronPython;
        dynamic IronPythonScript;
        public PlayerViewHost()
        {
            InitializeComponent();
            joinview = new JoinKalutView(this);
            IronPython = Python.CreateRuntime();
            IronPythonScript = IronPython.UseFile("Connection\\conn.py");
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
            status_lbl.Text = "Connecting...";
            await Task.Delay(1000);
            IronPythonScript.setup();
            string connected = IronPythonScript.connect(name, PIN);
            var data = JsonConvert.DeserializeObject<Dictionary<string, string>>(connected);
            if (data["status"] == "ok")
            {
                status_lbl.Text = "Connected!";
                status_spn.Spinning = false;
                status_spn.Value = 100;
                LoadQuiz();
                UID = int.Parse(data["UID"]);
            }
            else
            {
                status_lbl.Text = "Not connected!";
                DisplayJoinKalutView(true);
                joinview.err_lbl.Text = data["status"];
            }
                
        }
        private void LoadJoinKalutView()
        {
            Controls.Add(joinview);
            joinview.Show();
            joinview.Dock = DockStyle.Fill;
            joinview.BringToFront();
        }
        private async void LoadQuiz()
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
    }
}
