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
using Communicator;

namespace KalutClient
{
    public partial class QuizSelectionForm : MetroForm
    {
        WelcomeScreen parent;
        public QuizSelectionForm(WelcomeScreen parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void QuizSelectionForm_Load(object sender, EventArgs e)
        {
            LoadMyKaluts();
            LoadMyFavKaluts();
            LoadAllKaluts();
        }
        public void LoadMyFavKaluts()
        {
            PleaseWait w = new PleaseWait("Fetching your favorite kaluts from the server...");
            var worker = Communicator.Communicator.GetUserFavKalutsInfo(Properties.Settings.Default.Username,
                Properties.Settings.Default.Password);
            worker.ContinueWith(t => {
                w.Close();
                foreach (int uid in t.Result.Keys)
                {
                    myfav_kaluts_lst.Items.Add(new KalutInfo(uid, t.Result[uid]["Name"].ToString(), t.Result[uid]["Description"].ToString()));
                }
            },
            TaskScheduler.FromCurrentSynchronizationContext());
            w.ShowDialog();
        }
        public void LoadAllKaluts()
        {
            PleaseWait w = new PleaseWait("Fetching all kaluts list from the server...");
            var worker = Communicator.Communicator.GetAllKalutInfo();
            worker.ContinueWith(t => {
                w.Close();
                foreach (int uid in t.Result.Keys)
                {
                    all_kaluts_lst.Items.Add(new KalutInfo(uid, t.Result[uid]["Name"].ToString(), t.Result[uid]["Description"].ToString()));
                }
            },
            TaskScheduler.FromCurrentSynchronizationContext());
            w.ShowDialog();
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

        private void QuizSelectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0x0);
        }

        private void my_kaluts_lst_SelectedValueChanged(object sender, EventArgs e)
        {
            KalutInfo item = my_kaluts_lst.SelectedItem as KalutInfo;
            if (item != null)
            {
                my_desc_lbl.Text = item.Description;
                my_title_lbl.Text = item.Name;
            }
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void myfav_kaluts_lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            KalutInfo item = myfav_kaluts_lst.SelectedItem as KalutInfo;
            if (item != null)
            {
                myfav_desc_lbl.Text = item.Description;
                myfav_name_lbl.Text = item.Name;
            }
        }

        private void all_kaluts_lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            KalutInfo item = all_kaluts_lst.SelectedItem as KalutInfo;
            if (item != null)
            {
                all_desk_lbl.Text = item.Description;
                all_name_lbl.Text = item.Name;
            }
        }

        private void my_start_kalut_btn_Click(object sender, EventArgs e)
        {
            int uid = ((KalutInfo)my_kaluts_lst.SelectedItem).UID;
            WallViewHost wallview = new WallViewHost(uid);
            Hide();
            wallview.Show();
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            int uid = ((KalutInfo)all_kaluts_lst.SelectedItem).UID;
            WallViewHost wallview = new WallViewHost(uid);
            Hide();
            wallview.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            int uid = ((KalutInfo)myfav_kaluts_lst.SelectedItem).UID;
            WallViewHost wallview = new WallViewHost(uid);
            Hide();
            wallview.Show();
        }
    }
}
