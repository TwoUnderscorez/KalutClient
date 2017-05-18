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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.edit_kalut_btn = new MetroFramework.Controls.MetroButton();
            this.my_desc_lbl = new MetroFramework.Controls.MetroLabel();
            this.my_title_lbl = new MetroFramework.Controls.MetroLabel();
            this.my_kaluts_lst = new System.Windows.Forms.ListBox();
            this.editaQuiz_tab = new MetroFramework.Controls.MetroTabPage();
            this.quiz_editor_usrctrl = new KalutClient.QuizEditor();
            this.back_btn = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.newQuiz_tab.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.editaQuiz_tab.SuspendLayout();
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
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(697, 401);
            this.metroTabControl1.TabIndex = 0;
            // 
            // newQuiz_tab
            // 
            this.newQuiz_tab.Controls.Add(this.metroPanel1);
            this.newQuiz_tab.Controls.Add(this.my_kaluts_lst);
            this.newQuiz_tab.HorizontalScrollbarBarColor = true;
            this.newQuiz_tab.Location = new System.Drawing.Point(4, 35);
            this.newQuiz_tab.Name = "newQuiz_tab";
            this.newQuiz_tab.Size = new System.Drawing.Size(689, 362);
            this.newQuiz_tab.TabIndex = 0;
            this.newQuiz_tab.Text = "Edit a Kalut";
            this.newQuiz_tab.VerticalScrollbarBarColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.edit_kalut_btn);
            this.metroPanel1.Controls.Add(this.my_desc_lbl);
            this.metroPanel1.Controls.Add(this.my_title_lbl);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(443, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(237, 362);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // edit_kalut_btn
            // 
            this.edit_kalut_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.edit_kalut_btn.Highlight = true;
            this.edit_kalut_btn.Location = new System.Drawing.Point(4, 336);
            this.edit_kalut_btn.Name = "edit_kalut_btn";
            this.edit_kalut_btn.Size = new System.Drawing.Size(230, 23);
            this.edit_kalut_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.edit_kalut_btn.TabIndex = 4;
            this.edit_kalut_btn.Text = "Edit";
            // 
            // my_desc_lbl
            // 
            this.my_desc_lbl.AutoSize = true;
            this.my_desc_lbl.Location = new System.Drawing.Point(4, 29);
            this.my_desc_lbl.Name = "my_desc_lbl";
            this.my_desc_lbl.Size = new System.Drawing.Size(74, 19);
            this.my_desc_lbl.TabIndex = 3;
            this.my_desc_lbl.Text = "Description";
            // 
            // my_title_lbl
            // 
            this.my_title_lbl.AutoSize = true;
            this.my_title_lbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.my_title_lbl.Location = new System.Drawing.Point(4, 4);
            this.my_title_lbl.Name = "my_title_lbl";
            this.my_title_lbl.Size = new System.Drawing.Size(58, 25);
            this.my_title_lbl.TabIndex = 2;
            this.my_title_lbl.Text = "Name";
            // 
            // my_kaluts_lst
            // 
            this.my_kaluts_lst.Dock = System.Windows.Forms.DockStyle.Left;
            this.my_kaluts_lst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_kaluts_lst.FormattingEnabled = true;
            this.my_kaluts_lst.ItemHeight = 18;
            this.my_kaluts_lst.Location = new System.Drawing.Point(0, 0);
            this.my_kaluts_lst.Name = "my_kaluts_lst";
            this.my_kaluts_lst.Size = new System.Drawing.Size(443, 362);
            this.my_kaluts_lst.TabIndex = 3;
            this.my_kaluts_lst.SelectedIndexChanged += new System.EventHandler(this.my_kaluts_lst_SelectedIndexChanged);
            // 
            // editaQuiz_tab
            // 
            this.editaQuiz_tab.Controls.Add(this.quiz_editor_usrctrl);
            this.editaQuiz_tab.HorizontalScrollbarBarColor = true;
            this.editaQuiz_tab.Location = new System.Drawing.Point(4, 35);
            this.editaQuiz_tab.Name = "editaQuiz_tab";
            this.editaQuiz_tab.Size = new System.Drawing.Size(689, 362);
            this.editaQuiz_tab.TabIndex = 1;
            this.editaQuiz_tab.Text = "New Kalut";
            this.editaQuiz_tab.VerticalScrollbarBarColor = true;
            // 
            // quiz_editor_usrctrl
            // 
            this.quiz_editor_usrctrl.Location = new System.Drawing.Point(0, 3);
            this.quiz_editor_usrctrl.Name = "quiz_editor_usrctrl";
            this.quiz_editor_usrctrl.Size = new System.Drawing.Size(689, 363);
            this.quiz_editor_usrctrl.TabIndex = 2;
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
            this.newQuiz_tab.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.editaQuiz_tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage newQuiz_tab;
        private MetroFramework.Controls.MetroTabPage editaQuiz_tab;
        private MetroFramework.Controls.MetroButton back_btn;
        private System.Windows.Forms.ListBox my_kaluts_lst;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton edit_kalut_btn;
        private MetroFramework.Controls.MetroLabel my_desc_lbl;
        private MetroFramework.Controls.MetroLabel my_title_lbl;
        private QuizEditor quiz_editor_usrctrl;
    }
}