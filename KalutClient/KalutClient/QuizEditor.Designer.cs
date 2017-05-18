namespace KalutClient
{
    partial class QuizEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.q_gpbox = new System.Windows.Forms.GroupBox();
            this.q_time_adjust = new System.Windows.Forms.NumericUpDown();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.html_content_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.ans4_tog = new MetroFramework.Controls.MetroToggle();
            this.ans4_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.ans3_tog = new MetroFramework.Controls.MetroToggle();
            this.ans3_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.ans2_tog = new MetroFramework.Controls.MetroToggle();
            this.ans2_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.ans1_tog = new MetroFramework.Controls.MetroToggle();
            this.ans1_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.question_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.del_quiiz_btn = new MetroFramework.Controls.MetroButton();
            this.save_quiz_btn = new MetroFramework.Controls.MetroButton();
            this.delete_q_btn = new MetroFramework.Controls.MetroButton();
            this.add_q_btn = new MetroFramework.Controls.MetroButton();
            this.qs_lstbox = new KalutClient.RefreshListBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.quiz_desc_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.quiz_name_txt = new MetroFramework.Controls.MetroTextBox();
            this.player_timeout_chkbox = new MetroFramework.Controls.MetroCheckBox();
            this.player_timeout_val = new System.Windows.Forms.NumericUpDown();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.q_gpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q_time_adjust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_timeout_val)).BeginInit();
            this.SuspendLayout();
            // 
            // q_gpbox
            // 
            this.q_gpbox.BackColor = System.Drawing.Color.White;
            this.q_gpbox.Controls.Add(this.q_time_adjust);
            this.q_gpbox.Controls.Add(this.metroLabel11);
            this.q_gpbox.Controls.Add(this.html_content_txt);
            this.q_gpbox.Controls.Add(this.metroLabel10);
            this.q_gpbox.Controls.Add(this.metroLabel9);
            this.q_gpbox.Controls.Add(this.ans4_tog);
            this.q_gpbox.Controls.Add(this.ans4_txt);
            this.q_gpbox.Controls.Add(this.metroLabel8);
            this.q_gpbox.Controls.Add(this.ans3_tog);
            this.q_gpbox.Controls.Add(this.ans3_txt);
            this.q_gpbox.Controls.Add(this.metroLabel7);
            this.q_gpbox.Controls.Add(this.ans2_tog);
            this.q_gpbox.Controls.Add(this.ans2_txt);
            this.q_gpbox.Controls.Add(this.metroLabel6);
            this.q_gpbox.Controls.Add(this.ans1_tog);
            this.q_gpbox.Controls.Add(this.ans1_txt);
            this.q_gpbox.Controls.Add(this.metroLabel5);
            this.q_gpbox.Controls.Add(this.metroLabel4);
            this.q_gpbox.Controls.Add(this.question_txt);
            this.q_gpbox.Controls.Add(this.metroLabel3);
            this.q_gpbox.Location = new System.Drawing.Point(267, 30);
            this.q_gpbox.Name = "q_gpbox";
            this.q_gpbox.Size = new System.Drawing.Size(418, 234);
            this.q_gpbox.TabIndex = 22;
            this.q_gpbox.TabStop = false;
            // 
            // q_time_adjust
            // 
            this.q_time_adjust.BackColor = System.Drawing.SystemColors.Control;
            this.q_time_adjust.Location = new System.Drawing.Point(111, 206);
            this.q_time_adjust.Name = "q_time_adjust";
            this.q_time_adjust.Size = new System.Drawing.Size(301, 20);
            this.q_time_adjust.TabIndex = 30;
            this.q_time_adjust.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.q_time_adjust.ValueChanged += new System.EventHandler(this.q_time_adjust_ValueChanged);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(6, 207);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(99, 19);
            this.metroLabel11.TabIndex = 29;
            this.metroLabel11.Text = "Time (seconds):";
            // 
            // html_content_txt
            // 
            this.html_content_txt.Location = new System.Drawing.Point(108, 177);
            this.html_content_txt.Name = "html_content_txt";
            this.html_content_txt.Size = new System.Drawing.Size(304, 23);
            this.html_content_txt.Style = MetroFramework.MetroColorStyle.Blue;
            this.html_content_txt.TabIndex = 28;
            this.html_content_txt.UseStyleColors = true;
            this.html_content_txt.TextChanged += new System.EventHandler(this.html_content_txt_TextChanged);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(6, 178);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(96, 19);
            this.metroLabel10.TabIndex = 27;
            this.metroLabel10.Text = "HTML Content:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(332, 39);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(58, 19);
            this.metroLabel9.TabIndex = 26;
            this.metroLabel9.Text = "Correct?";
            // 
            // ans4_tog
            // 
            this.ans4_tog.AutoSize = true;
            this.ans4_tog.Location = new System.Drawing.Point(332, 151);
            this.ans4_tog.Name = "ans4_tog";
            this.ans4_tog.Size = new System.Drawing.Size(80, 17);
            this.ans4_tog.TabIndex = 25;
            this.ans4_tog.Text = "Off";
            this.ans4_tog.UseVisualStyleBackColor = true;
            this.ans4_tog.CheckedChanged += new System.EventHandler(this.ans4_tog_CheckedChanged);
            // 
            // ans4_txt
            // 
            this.ans4_txt.Location = new System.Drawing.Point(29, 148);
            this.ans4_txt.Name = "ans4_txt";
            this.ans4_txt.Size = new System.Drawing.Size(297, 23);
            this.ans4_txt.Style = MetroFramework.MetroColorStyle.Blue;
            this.ans4_txt.TabIndex = 24;
            this.ans4_txt.UseStyleColors = true;
            this.ans4_txt.TextChanged += new System.EventHandler(this.ans4_txt_TextChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(6, 149);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(20, 19);
            this.metroLabel8.TabIndex = 23;
            this.metroLabel8.Text = "4)";
            // 
            // ans3_tog
            // 
            this.ans3_tog.AutoSize = true;
            this.ans3_tog.Location = new System.Drawing.Point(332, 122);
            this.ans3_tog.Name = "ans3_tog";
            this.ans3_tog.Size = new System.Drawing.Size(80, 17);
            this.ans3_tog.TabIndex = 22;
            this.ans3_tog.Text = "Off";
            this.ans3_tog.UseVisualStyleBackColor = true;
            this.ans3_tog.CheckedChanged += new System.EventHandler(this.ans3_tog_CheckedChanged);
            // 
            // ans3_txt
            // 
            this.ans3_txt.Location = new System.Drawing.Point(29, 119);
            this.ans3_txt.Name = "ans3_txt";
            this.ans3_txt.Size = new System.Drawing.Size(297, 23);
            this.ans3_txt.Style = MetroFramework.MetroColorStyle.Blue;
            this.ans3_txt.TabIndex = 21;
            this.ans3_txt.UseStyleColors = true;
            this.ans3_txt.TextChanged += new System.EventHandler(this.ans3_txt_TextChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(6, 120);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(20, 19);
            this.metroLabel7.TabIndex = 20;
            this.metroLabel7.Text = "3)";
            // 
            // ans2_tog
            // 
            this.ans2_tog.AutoSize = true;
            this.ans2_tog.Location = new System.Drawing.Point(332, 93);
            this.ans2_tog.Name = "ans2_tog";
            this.ans2_tog.Size = new System.Drawing.Size(80, 17);
            this.ans2_tog.TabIndex = 19;
            this.ans2_tog.Text = "Off";
            this.ans2_tog.UseVisualStyleBackColor = true;
            this.ans2_tog.CheckedChanged += new System.EventHandler(this.ans2_tog_CheckedChanged);
            // 
            // ans2_txt
            // 
            this.ans2_txt.Location = new System.Drawing.Point(29, 90);
            this.ans2_txt.Name = "ans2_txt";
            this.ans2_txt.Size = new System.Drawing.Size(297, 23);
            this.ans2_txt.Style = MetroFramework.MetroColorStyle.Blue;
            this.ans2_txt.TabIndex = 18;
            this.ans2_txt.UseStyleColors = true;
            this.ans2_txt.TextChanged += new System.EventHandler(this.ans2_txt_TextChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 91);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(20, 19);
            this.metroLabel6.TabIndex = 17;
            this.metroLabel6.Text = "2)";
            // 
            // ans1_tog
            // 
            this.ans1_tog.AutoSize = true;
            this.ans1_tog.Location = new System.Drawing.Point(332, 64);
            this.ans1_tog.Name = "ans1_tog";
            this.ans1_tog.Size = new System.Drawing.Size(80, 17);
            this.ans1_tog.TabIndex = 16;
            this.ans1_tog.Text = "Off";
            this.ans1_tog.UseVisualStyleBackColor = true;
            this.ans1_tog.CheckedChanged += new System.EventHandler(this.ans1_tog_CheckedChanged);
            // 
            // ans1_txt
            // 
            this.ans1_txt.Location = new System.Drawing.Point(29, 61);
            this.ans1_txt.Name = "ans1_txt";
            this.ans1_txt.Size = new System.Drawing.Size(297, 23);
            this.ans1_txt.Style = MetroFramework.MetroColorStyle.Blue;
            this.ans1_txt.TabIndex = 15;
            this.ans1_txt.UseStyleColors = true;
            this.ans1_txt.TextChanged += new System.EventHandler(this.ans1_txt_TextChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 62);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(18, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "1)";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(10, 39);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Answers:";
            // 
            // question_txt
            // 
            this.question_txt.Location = new System.Drawing.Point(80, 15);
            this.question_txt.Name = "question_txt";
            this.question_txt.Size = new System.Drawing.Size(332, 23);
            this.question_txt.Style = MetroFramework.MetroColorStyle.Blue;
            this.question_txt.TabIndex = 12;
            this.question_txt.UseStyleColors = true;
            this.question_txt.TextChanged += new System.EventHandler(this.question_txt_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(10, 16);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Question:";
            // 
            // del_quiiz_btn
            // 
            this.del_quiiz_btn.Location = new System.Drawing.Point(267, 333);
            this.del_quiiz_btn.Name = "del_quiiz_btn";
            this.del_quiiz_btn.Size = new System.Drawing.Size(418, 23);
            this.del_quiiz_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.del_quiiz_btn.TabIndex = 21;
            this.del_quiiz_btn.Text = "Discard Quiz";
            this.del_quiiz_btn.Click += new System.EventHandler(this.del_quiiz_btn_Click);
            // 
            // save_quiz_btn
            // 
            this.save_quiz_btn.Highlight = true;
            this.save_quiz_btn.Location = new System.Drawing.Point(267, 307);
            this.save_quiz_btn.Name = "save_quiz_btn";
            this.save_quiz_btn.Size = new System.Drawing.Size(418, 23);
            this.save_quiz_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.save_quiz_btn.TabIndex = 20;
            this.save_quiz_btn.Text = "Save Quiz";
            this.save_quiz_btn.Click += new System.EventHandler(this.save_quiz_btn_Click);
            // 
            // delete_q_btn
            // 
            this.delete_q_btn.Location = new System.Drawing.Point(3, 333);
            this.delete_q_btn.Name = "delete_q_btn";
            this.delete_q_btn.Size = new System.Drawing.Size(258, 23);
            this.delete_q_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.delete_q_btn.TabIndex = 19;
            this.delete_q_btn.Text = "Delete Selected Question";
            // 
            // add_q_btn
            // 
            this.add_q_btn.Highlight = true;
            this.add_q_btn.Location = new System.Drawing.Point(3, 307);
            this.add_q_btn.Name = "add_q_btn";
            this.add_q_btn.Size = new System.Drawing.Size(258, 23);
            this.add_q_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.add_q_btn.TabIndex = 18;
            this.add_q_btn.Text = "Add a Question";
            this.add_q_btn.Click += new System.EventHandler(this.add_q_btn_Click);
            // 
            // qs_lstbox
            // 
            this.qs_lstbox.FormattingEnabled = true;
            this.qs_lstbox.Location = new System.Drawing.Point(3, 24);
            this.qs_lstbox.Name = "qs_lstbox";
            this.qs_lstbox.Size = new System.Drawing.Size(258, 277);
            this.qs_lstbox.TabIndex = 17;
            this.qs_lstbox.SelectedValueChanged += new System.EventHandler(this.qs_lstbox_SelectedValueChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(267, 1);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Description";
            // 
            // quiz_desc_txt
            // 
            this.quiz_desc_txt.Location = new System.Drawing.Point(347, 1);
            this.quiz_desc_txt.Name = "quiz_desc_txt";
            this.quiz_desc_txt.Size = new System.Drawing.Size(341, 23);
            this.quiz_desc_txt.Style = MetroFramework.MetroColorStyle.Blue;
            this.quiz_desc_txt.TabIndex = 15;
            this.quiz_desc_txt.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(-1, 1);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Name";
            // 
            // quiz_name_txt
            // 
            this.quiz_name_txt.Location = new System.Drawing.Point(50, 1);
            this.quiz_name_txt.Name = "quiz_name_txt";
            this.quiz_name_txt.Size = new System.Drawing.Size(211, 23);
            this.quiz_name_txt.Style = MetroFramework.MetroColorStyle.Blue;
            this.quiz_name_txt.TabIndex = 13;
            this.quiz_name_txt.Text = "Untitled Kalut";
            this.quiz_name_txt.UseStyleColors = true;
            // 
            // player_timeout_chkbox
            // 
            this.player_timeout_chkbox.AutoSize = true;
            this.player_timeout_chkbox.Location = new System.Drawing.Point(267, 270);
            this.player_timeout_chkbox.Name = "player_timeout_chkbox";
            this.player_timeout_chkbox.Size = new System.Drawing.Size(126, 15);
            this.player_timeout_chkbox.TabIndex = 23;
            this.player_timeout_chkbox.Text = "Player join timeout:";
            this.player_timeout_chkbox.UseVisualStyleBackColor = true;
            this.player_timeout_chkbox.CheckedChanged += new System.EventHandler(this.player_timeout_chkbox_CheckedChanged);
            // 
            // player_timeout_val
            // 
            this.player_timeout_val.Location = new System.Drawing.Point(399, 268);
            this.player_timeout_val.Name = "player_timeout_val";
            this.player_timeout_val.Size = new System.Drawing.Size(120, 20);
            this.player_timeout_val.TabIndex = 24;
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(525, 268);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(160, 20);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 25;
            this.metroButton1.Text = "Preview Quiz";
            // 
            // QuizEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.player_timeout_val);
            this.Controls.Add(this.player_timeout_chkbox);
            this.Controls.Add(this.q_gpbox);
            this.Controls.Add(this.del_quiiz_btn);
            this.Controls.Add(this.save_quiz_btn);
            this.Controls.Add(this.delete_q_btn);
            this.Controls.Add(this.add_q_btn);
            this.Controls.Add(this.qs_lstbox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.quiz_desc_txt);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.quiz_name_txt);
            this.Name = "QuizEditor";
            this.Size = new System.Drawing.Size(689, 363);
            this.Load += new System.EventHandler(this.QuizEditor_Load);
            this.q_gpbox.ResumeLayout(false);
            this.q_gpbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q_time_adjust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_timeout_val)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox q_gpbox;
        private System.Windows.Forms.NumericUpDown q_time_adjust;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox html_content_txt;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroToggle ans4_tog;
        private MetroFramework.Controls.MetroTextBox ans4_txt;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroToggle ans3_tog;
        private MetroFramework.Controls.MetroTextBox ans3_txt;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroToggle ans2_tog;
        private MetroFramework.Controls.MetroTextBox ans2_txt;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroToggle ans1_tog;
        private MetroFramework.Controls.MetroTextBox ans1_txt;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox question_txt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton del_quiiz_btn;
        private MetroFramework.Controls.MetroButton save_quiz_btn;
        private MetroFramework.Controls.MetroButton delete_q_btn;
        private MetroFramework.Controls.MetroButton add_q_btn;
        private KalutClient.RefreshListBox qs_lstbox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox quiz_desc_txt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox quiz_name_txt;
        private MetroFramework.Controls.MetroCheckBox player_timeout_chkbox;
        private System.Windows.Forms.NumericUpDown player_timeout_val;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}
