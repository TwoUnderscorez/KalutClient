using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using KalutClient.Objects;

namespace KalutClient
{
    public partial class WallAnswerView : MetroUserControl
    {
        MetroTile[] ansTiles = new MetroTile[4];
        WallViewHost parent;
        KalutQuestion curr_q;
        public WallAnswerView(WallViewHost parent)
        {
            InitializeComponent();
            ansTiles[0] = ans0_tile;
            ansTiles[1] = ans1_tile;
            ansTiles[2] = ans2_tile;
            ansTiles[3] = ans3_tile;
            this.parent = parent;
        }

        private void WallAnswerView_Load(object sender, EventArgs e)
        {
            
        }
        public void SetCorrectAnswer(int[] index)
        {
            for (int i = 0; i < 4; i++)
                if (!index.Contains(i))
                    ansTiles[i].Style = MetroFramework.MetroColorStyle.Silver;
        }
        public void ResetAnsTiles()
        {
            ans0_tile.Style = MetroFramework.MetroColorStyle.Blue;
            ans1_tile.Style = MetroFramework.MetroColorStyle.Green;
            ans2_tile.Style = MetroFramework.MetroColorStyle.Yellow;
            ans3_tile.Style = MetroFramework.MetroColorStyle.Red;
        }
        public void Update(KalutQuestion q)
        {
            curr_q = q;
            question_txt.Text = q.Question;
            ans0_tile.Text = q.Answers[0].Key;
            ans1_tile.Text = q.Answers[1].Key;
            ans2_tile.Text = q.Answers[2].Key;
            ans3_tile.Text = q.Answers[3].Key;
            string html = string.Format("<img src=\"{0}\" width=\"{1}\" height=\"{2}\">", q.HTMLContent, webBrowser.Size.Width, webBrowser.Size.Height);
            if (html != webBrowser.DocumentText)
            {
                webBrowser.Navigate("about:blank");
                webBrowser.Document.OpenNew(false);
                webBrowser.Document.Write(html);
                webBrowser.Refresh();
            }
        }

        private void nextq_btn_Click(object sender, EventArgs e)
        {
            parent.NextButtonClick();
        }

        private void show_ans_btn_Click(object sender, EventArgs e)
        {
            SetCorrectAnswer(FindCorrectAnsIndex(curr_q));
        }
        private int[] FindCorrectAnsIndex(KalutQuestion q)
        {
            int[] retdata = new int[4];
            for (int i = 0; i < 4; i++) 
            {
                if (curr_q.Answers[i].Value)
                    retdata[i] = i;
                else
                    retdata[i] = -1;
            }
            return retdata;
        }
    }
}
