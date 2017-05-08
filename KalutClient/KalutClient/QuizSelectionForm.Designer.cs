namespace KalutClient
{
    partial class QuizSelectionForm
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
            this.myQuizes_tab = new MetroFramework.Controls.MetroTabPage();
            this.onlineQuizes_tab = new MetroFramework.Controls.MetroTabPage();
            this.favQuiz_tab = new MetroFramework.Controls.MetroTabPage();
            this.back_btn = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.myQuizes_tab);
            this.metroTabControl1.Controls.Add(this.onlineQuizes_tab);
            this.metroTabControl1.Controls.Add(this.favQuiz_tab);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(697, 407);
            this.metroTabControl1.TabIndex = 0;
            // 
            // myQuizes_tab
            // 
            this.myQuizes_tab.HorizontalScrollbarBarColor = true;
            this.myQuizes_tab.Location = new System.Drawing.Point(4, 35);
            this.myQuizes_tab.Name = "myQuizes_tab";
            this.myQuizes_tab.Size = new System.Drawing.Size(689, 368);
            this.myQuizes_tab.Style = MetroFramework.MetroColorStyle.Blue;
            this.myQuizes_tab.TabIndex = 0;
            this.myQuizes_tab.Text = "My Kaluts";
            this.myQuizes_tab.VerticalScrollbarBarColor = true;
            // 
            // onlineQuizes_tab
            // 
            this.onlineQuizes_tab.HorizontalScrollbarBarColor = true;
            this.onlineQuizes_tab.Location = new System.Drawing.Point(4, 35);
            this.onlineQuizes_tab.Name = "onlineQuizes_tab";
            this.onlineQuizes_tab.Size = new System.Drawing.Size(689, 368);
            this.onlineQuizes_tab.TabIndex = 1;
            this.onlineQuizes_tab.Text = "Kaluts Made by Other People";
            this.onlineQuizes_tab.VerticalScrollbarBarColor = true;
            // 
            // favQuiz_tab
            // 
            this.favQuiz_tab.HorizontalScrollbarBarColor = true;
            this.favQuiz_tab.Location = new System.Drawing.Point(4, 35);
            this.favQuiz_tab.Name = "favQuiz_tab";
            this.favQuiz_tab.Size = new System.Drawing.Size(689, 368);
            this.favQuiz_tab.TabIndex = 2;
            this.favQuiz_tab.Text = "My Favorite Kaluts";
            this.favQuiz_tab.VerticalScrollbarBarColor = true;
            // 
            // back_btn
            // 
            this.back_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.back_btn.Highlight = true;
            this.back_btn.Location = new System.Drawing.Point(643, 25);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(73, 23);
            this.back_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.back_btn.TabIndex = 2;
            this.back_btn.Text = "Back";
            this.back_btn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // QuizSelectionForm
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
            this.Name = "QuizSelectionForm";
            this.Text = "Select A Quiz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuizSelectionForm_FormClosing);
            this.Load += new System.EventHandler(this.QuizSelectionForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage myQuizes_tab;
        private MetroFramework.Controls.MetroTabPage onlineQuizes_tab;
        private MetroFramework.Controls.MetroTabPage favQuiz_tab;
        private MetroFramework.Controls.MetroButton back_btn;
    }
}