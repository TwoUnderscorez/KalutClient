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
using Communicator;
using IronPython.Hosting;

namespace KalutClient
{ 
    public partial class WelcomeScreen : MetroForm
    {
        QuizMakerForm qmaker;
        QuizSelectionForm qselector;
        public static bool LoggedIn
        {
            get
            {
                return !string.IsNullOrEmpty(Properties.Settings.Default.Username) && !string.IsNullOrEmpty(Properties.Settings.Default.Password);
            }
        }
        public WelcomeScreen()
        {
            InitializeComponent();
            qmaker = new QuizMakerForm(this);
            qselector = new QuizSelectionForm(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {//          ^ login_lnk
            LoginForm login = new LoginForm();
            login.ShowDialog();
            string usrname = Properties.Settings.Default.Username;
            if (!string.IsNullOrEmpty(usrname))
            {
                login_lnk.Text = string.Format("Welcome, {0}!", usrname);
            }
            else
            {
                login_lnk.Text = "Log in";
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (LoggedIn)
            {
                Hide();
                qselector = new QuizSelectionForm(this);
                qselector.Show();
            }
            else
            {
                MessageBox.Show("You must be logged in to open that window.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (LoggedIn)
            {
                Hide();
                qmaker = new QuizMakerForm(this);
                qmaker.Show();
            }
            else
            {
                MessageBox.Show("You must be logged in to open that window.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WelcomeScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0x0);
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            PlayerViewHost player = new PlayerViewHost();
            Hide();
            player.Show();
        }

        private void srv_sts_lnk_Click(object sender, EventArgs e)
        {
            /*
             * Run Get("/") in a different thread because it might take some time. 
             * Now when it's finished, or if it crashed, doesn't matter, run this 
             * piece of code bellow in the UI thread.
             */
            UseWaitCursor = true;
            srv_sts_lnk.Style = MetroFramework.MetroColorStyle.Blue;
            srv_sts_lnk.Text = "Checking service status...";
            var worker = Communicator.Communicator.GET("/");
            worker.ContinueWith( t => {
                UseWaitCursor = false;
                if (t.IsCanceled || t.IsFaulted)
                {
                    srv_sts_lnk.Text = "Seems like our server are down... :(";
                    srv_sts_lnk.Style = MetroFramework.MetroColorStyle.Red;
                }
                else if (t.Result.Data["Service Status"].ToString() == "OK")
                {
                    srv_sts_lnk.Text = "Service is operating normally.";
                    srv_sts_lnk.Style = MetroFramework.MetroColorStyle.Green;
                }
                else
                {
                    srv_sts_lnk.Text = "Seems like our server are down... :(";
                    srv_sts_lnk.Style = MetroFramework.MetroColorStyle.Red;
                }
            },
            TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
