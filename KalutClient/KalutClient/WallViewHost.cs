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

namespace KalutClient
{
    public partial class WallViewHost : MetroForm
    {
        private int UID;
        private int PIN;
        ScriptRuntime IronPython;
        dynamic IronPythonScript;
        public WallViewHost(int KalutUID)
        {
            IronPython = Python.CreateRuntime();
            IronPythonScript = IronPython.UseFile("Connection\\conn.py");
            UID = KalutUID;
            InitializeComponent();
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
                status_lbl.Text = string.Format("Connecting... (PIN={0})", PIN);
                await Task.Delay(1000);
                Connect();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void Connect()
        {
            IronPythonScript.setup();
            string connected = IronPythonScript.connect("@#@WALLVIEW@#@", PIN);
            var data = JsonConvert.DeserializeObject<Dictionary<string, string>>(connected);
            if (data["status"] == "ok")
            { 
                status_lbl.Text = string.Format("Connected! (PIN={0})", PIN);
                status_spn.Spinning = false;
                status_spn.Value = 100;
                timer1.Start();
            }
            else
                status_lbl.Text = string.Format("Not connected! (PIN={0})", PIN);
        }

        private void metroProgressSpinner1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(IronPythonScript.get_list_of_players());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            metroLabel1.Text = IronPythonScript.get_list_of_players();
        }
    }
}
