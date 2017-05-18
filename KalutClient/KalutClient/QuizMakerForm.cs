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
using KalutClient.Objects;

namespace KalutClient
{
    public partial class QuizMakerForm : MetroForm
    {
        WelcomeScreen parent;
        public QuizMakerForm(WelcomeScreen parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void QuizMakerFormcs_Load(object sender, EventArgs e)
        {
            LoadMyKaluts();
        }
        public void LoadMyKaluts()
        {
            PleaseWait w = new PleaseWait("Fetching your kaluts from the server...");
            var worker = Communicator.Communicator.GetUserKalutsInfo(Properties.Settings.Default.Username,
                Properties.Settings.Default.Password);
            worker.ContinueWith(t => {
                w.Close();
                foreach (int uid in t.Result.Keys)
                {
                    my_kaluts_lst.Items.Add(new KalutInfo(uid, t.Result[uid]["Name"].ToString(), t.Result[uid]["Description"].ToString()));
                }
            },
            TaskScheduler.FromCurrentSynchronizationContext());
            w.ShowDialog();
        }
        private void back_btn_Click(object sender, EventArgs e)
        {
            parent.Show();
            Hide();
        }

        private void QuizMakerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0x0);
        }

        private void my_kaluts_lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            KalutInfo item = my_kaluts_lst.SelectedItem as KalutInfo;
            if (item != null)
            {
                my_desc_lbl.Text = item.Description;
                my_title_lbl.Text = item.Name;
            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
