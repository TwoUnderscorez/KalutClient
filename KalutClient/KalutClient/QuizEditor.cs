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
using Communicator;
using Newtonsoft.Json;
using KalutClient;


namespace KalutClient
{
    public partial class QuizEditor : MetroUserControl
    {
        public QuizEditor()
        {
            InitializeComponent();
        }
        private void EnableQuizMaker(bool e)
        {
            quiz_name_txt.Enabled = e;
            quiz_desc_txt.Enabled = e;
            ans1_tog.Enabled = e;
            ans2_tog.Enabled = e;
            ans3_tog.Enabled = e;
            ans4_tog.Enabled = e;
            ans1_txt.Enabled = e;
            ans2_txt.Enabled = e;
            ans3_txt.Enabled = e;
            ans4_txt.Enabled = e;
        }
        private void ResetQuizMaker()
        {
            qs_lstbox.Items.Clear();
            quiz_name_txt.Text = "";
            quiz_desc_txt.Text = "";
            ans1_tog.Checked = false;
            ans2_tog.Checked = false;
            ans3_tog.Checked = false;
            ans4_tog.Checked = false;
            ans1_txt.Text = "";
            ans2_txt.Text = "";
            ans3_txt.Text = "";
            ans4_txt.Text = "";
        }
        private void ResetQuestion()
        {
            ans1_tog.Checked = false;
            ans2_tog.Checked = false;
            ans3_tog.Checked = false;
            ans4_tog.Checked = false;
            ans1_txt.Text = "";
            ans2_txt.Text = "";
            ans3_txt.Text = "";
            ans4_txt.Text = "";
            html_content_txt.Text = "";
            q_time_adjust.Value = 60;
            q_gpbox.Text = "";
            question_txt.Text = "";
        }
        private void UpdateQuestion(KalutQuestion q)
        {
            if (q == null)
                return;
            ans1_tog.Checked = q.Answers[0].Value;
            ans2_tog.Checked = q.Answers[1].Value;
            ans3_tog.Checked = q.Answers[2].Value;
            ans4_tog.Checked = q.Answers[3].Value;
            ans1_txt.Text = q.Answers[0].Key;
            ans2_txt.Text = q.Answers[1].Key;
            ans3_txt.Text = q.Answers[2].Key;
            ans4_txt.Text = q.Answers[3].Key;
            html_content_txt.Text = q.HTMLContent;
            q_time_adjust.Value = q.Time;
            q_gpbox.Text = q.Question;
            question_txt.Text = q.Question;
        }
        private void EnableQuestion(bool e)
        {
            ans1_tog.Enabled = e;
            ans2_tog.Enabled = e;
            ans3_tog.Enabled = e;
            ans4_tog.Enabled = e;
            ans1_txt.Enabled = e;
            ans2_txt.Enabled = e;
            ans3_txt.Enabled = e;
            ans4_txt.Enabled = e;
            html_content_txt.Enabled = e;
            q_time_adjust.Enabled = e;
            q_gpbox.Enabled = e;
            question_txt.Enabled = e;
        }
        private void QuizEditor_Load(object sender, EventArgs e)
        {

            ResetQuestion();
            ResetQuizMaker();
            EnableQuestion(false);
            EnableQuizMaker(true);
        }

        private void question_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                q_gpbox.Text = question_txt.Text;
                ((KalutQuestion)qs_lstbox.SelectedItem).Question = question_txt.Text;
            }
            catch { }
        }

        private void add_q_btn_Click(object sender, EventArgs e)
        {
            qs_lstbox.Items.Add(new KalutQuestion("Untitled Question"));
        }

        private void qs_lstbox_SelectedValueChanged(object sender, EventArgs e)
        {
            EnableQuestion(false);
            UpdateQuestion((KalutQuestion)qs_lstbox.SelectedItem);
            for (int i = 0; i < qs_lstbox.Items.Count; i++)
                if (i != qs_lstbox.SelectedIndex)
                    qs_lstbox.Items[i] = qs_lstbox.Items[i];
            EnableQuestion((qs_lstbox.SelectedItem!=null));
        }

        private void ans1_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((KalutQuestion)qs_lstbox.SelectedItem).Answers[0] = new KeyValuePair<string, bool>(
                    ans1_txt.Text, ((KalutQuestion)qs_lstbox.SelectedItem).Answers[0].Value);
            }
            catch { }
        }

        private void ans2_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((KalutQuestion)qs_lstbox.SelectedItem).Answers[1] = new KeyValuePair<string, bool>(
                    ans2_txt.Text, ((KalutQuestion)qs_lstbox.SelectedItem).Answers[1].Value);
            }
            catch { }

        }

        private void ans3_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((KalutQuestion)qs_lstbox.SelectedItem).Answers[2] = new KeyValuePair<string, bool>(
                    ans3_txt.Text, ((KalutQuestion)qs_lstbox.SelectedItem).Answers[2].Value);
            }
            catch { }

        }

        private void ans4_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((KalutQuestion)qs_lstbox.SelectedItem).Answers[3] = new KeyValuePair<string, bool>(
                    ans4_txt.Text, ((KalutQuestion)qs_lstbox.SelectedItem).Answers[3].Value);
            }
            catch { }

        }

        private void ans1_tog_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ((KalutQuestion)qs_lstbox.SelectedItem).Answers[0] = new KeyValuePair<string, bool>(
                    ((KalutQuestion)qs_lstbox.SelectedItem).Answers[0].Key, ans1_tog.Checked);
            }
            catch { }

        }

        private void ans2_tog_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ((KalutQuestion)qs_lstbox.SelectedItem).Answers[1] = new KeyValuePair<string, bool>(
                    ((KalutQuestion)qs_lstbox.SelectedItem).Answers[1].Key, ans2_tog.Checked);
            }
            catch { }
            
        }

        private void ans3_tog_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ((KalutQuestion)qs_lstbox.SelectedItem).Answers[2] = new KeyValuePair<string, bool>(
                    ((KalutQuestion)qs_lstbox.SelectedItem).Answers[2].Key, ans3_tog.Checked);
            }
            catch { }

        }

        private void ans4_tog_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ((KalutQuestion)qs_lstbox.SelectedItem).Answers[3] = new KeyValuePair<string, bool>(
                    ((KalutQuestion)qs_lstbox.SelectedItem).Answers[3].Key, ans4_tog.Checked);
            }
            catch { }

        }

        private void q_time_adjust_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                ((KalutQuestion)qs_lstbox.SelectedItem).Time = (int)q_time_adjust.Value;
            }
            catch { }
        }

        private void save_quiz_btn_Click(object sender, EventArgs e)
        {
            PleaseWait w = new PleaseWait("Uploading quiz...");
            List<KalutQuestion> qs = new List<KalutQuestion>();
            for (int i = 0; i < qs_lstbox.Items.Count; i++)
                qs.Add((KalutQuestion)qs_lstbox.Items[i]);
            KalutInfo info = new KalutInfo(-1, quiz_name_txt.Text, quiz_desc_txt.Text);
            KalutQuiz quiz = new KalutQuiz(info, qs);
            var worker = Communicator.Communicator.AddKalut(
                Properties.Settings.Default.Username,
                Properties.Settings.Default.Password,
                JsonConvert.SerializeObject(info),
                JsonConvert.SerializeObject(qs));
            worker.ContinueWith(t =>
            {
                w.Close();
                if(t.IsCanceled || t.IsFaulted)
                {
                    MessageBox.Show("Unexpected error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    StandartResponse rsp = t.Result;
                    if (rsp.Status == "OK")
                    {
                        MessageBox.Show("Uploaded successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetQuizMaker();
                        ResetQuestion();
                        EnableQuestion(false); 
                    }
                    else
                    {
                        MessageBox.Show("Error: " + rsp.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            },
            TaskScheduler.FromCurrentSynchronizationContext());
            w.ShowDialog();
        }

        private void html_content_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((KalutQuestion)qs_lstbox.SelectedItem).HTMLContent = html_content_txt.Text;
            }
            catch { }
        }

        private void player_timeout_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            player_timeout_val.Enabled = player_timeout_chkbox.Checked;
        }

        private void del_quiiz_btn_Click(object sender, EventArgs e)
        {
            ResetQuestion();
            ResetQuizMaker();
            EnableQuestion(false);
            EnableQuizMaker(true);
        }
    }
}
