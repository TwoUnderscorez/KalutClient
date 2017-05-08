namespace KalutClient
{
    partial class QuizMakerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.newQuiz_tab = new MetroFramework.Controls.MetroTabPage();
            this.editaQuiz_tab = new MetroFramework.Controls.MetroTabPage();
            this.back_btn = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.newQuiz_tab);
            this.metroTabControl1.Controls.Add(this.editaQuiz_tab);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(697, 401);
            this.metroTabControl1.TabIndex = 0;
            // 
            // newQuiz_tab
            // 
            this.newQuiz_tab.HorizontalScrollbarBarColor = true;
            this.newQuiz_tab.Location = new System.Drawing.Point(4, 35);
            this.newQuiz_tab.Name = "newQuiz_tab";
            this.newQuiz_tab.Size = new System.Drawing.Size(689, 362);
            this.newQuiz_tab.TabIndex = 0;
            this.newQuiz_tab.Text = "New Kalut";
            this.newQuiz_tab.VerticalScrollbarBarColor = true;
            // 
            // editaQuiz_tab
            // 
            this.editaQuiz_tab.HorizontalScrollbarBarColor = true;
            this.editaQuiz_tab.Location = new System.Drawing.Point(4, 35);
            this.editaQuiz_tab.Name = "editaQuiz_tab";
            this.editaQuiz_tab.Size = new System.Drawing.Size(689, 362);
            this.editaQuiz_tab.TabIndex = 1;
            this.editaQuiz_tab.Text = "Edit a Kalut";
            this.editaQuiz_tab.VerticalScrollbarBarColor = true;
            // 
            // back_btn
            // 
            this.back_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.back_btn.Highlight = true;
            this.back_btn.Location = new System.Drawing.Point(643, 28);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(77, 23);
            this.back_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.back_btn.TabIndex = 1;
            this.back_btn.Text = "Back";
            this.back_btn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // QuizMakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 493);
            this.ControlBox = false;
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(743, 493);
            this.Name = "QuizMakerForm";
            this.Text = "Quiz Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuizMakerForm_FormClosing);
            this.Load += new System.EventHandler(this.QuizMakerFormcs_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage newQuiz_tab;
        private MetroFramework.Controls.MetroTabPage editaQuiz_tab;
        private MetroFramework.Controls.MetroButton back_btn;
    }
}