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

namespace KalutClient
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fpwd_lnk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Well that's unfortunate, isn't it?", "Kalut", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            PleaseWait w = new PleaseWait("Logging in...");
            var worker = Communicator.Communicator.Authenticate(usr_txt.Text, pwd_txt.Text);
            worker.ContinueWith(t =>
            {
                w.Close();
                if (t.IsFaulted || t.IsCanceled)
                {
                    MessageBox.Show("Could not complete the operation. Is the service running?",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
                else if (t.Result)
                {
                    Properties.Settings.Default.Username = usr_txt.Text;
                    Properties.Settings.Default.Password = pwd_txt.Text;
                    Close();
                }
                else
                {
                    MessageBox.Show("Username and password do not match. Are you registered?",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            },
            TaskScheduler.FromCurrentSynchronizationContext());
            w.ShowDialog();
        }
    }
}
