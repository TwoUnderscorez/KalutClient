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

namespace KalutClient
{
    public partial class Register : MetroForm
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(pwd_txt.Text != repawd_txt.Text)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PleaseWait w = new PleaseWait("Signing up...");
            var worker = Communicator.Communicator.Register(usrname_txt.Text, pwd_txt.Text);
            worker.ContinueWith(t =>
            {
                w.Close();
                if (t.IsFaulted || t.IsCanceled)
                {
                    MessageBox.Show("Could not complete the operation. Is the service running?",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
                else if (t.Result=="ok")
                {
                    MessageBox.Show("Registration completed successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Could not complete the operation. Perhaps the username is already taken.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            },
            TaskScheduler.FromCurrentSynchronizationContext());
            w.ShowDialog();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
