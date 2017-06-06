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
    public partial class AnswerQuestionView : MetroUserControl
    {
        KalutQuestion QuestionData;
        PlayerViewHost parent;
        public AnswerQuestionView(PlayerViewHost parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void AnswerQuestionView_Load(object sender, EventArgs e)
        {

        }
        public void Update(KalutQuestion q)
        {
            question_txt.Text = q.Question;
            ans0_tile.Text = q.Answers[0].Key;
            ans1_tile.Text = q.Answers[1].Key;
            ans2_tile.Text = q.Answers[2].Key;
            ans3_tile.Text = q.Answers[3].Key;
            timeout_spn.Maximum = q.Time;
            timeout_spn.Value = q.Time;
            timeout_txt.Text = q.Time.ToString();

        }

        private void ans0_tile_Click(object sender, EventArgs e)
        {
            parent.Answer(0);
        }

        private void ans1_tile_Click(object sender, EventArgs e)
        {
            parent.Answer(1);
        }

        private void ans2_tile_Click(object sender, EventArgs e)
        {
            parent.Answer(2);
        }

        private void ans3_tile_Click(object sender, EventArgs e)
        {
            parent.Answer(3);
        }
    }
}
