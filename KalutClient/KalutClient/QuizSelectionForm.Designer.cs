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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.my_start_kalut_btn = new MetroFramework.Controls.MetroButton();
            this.my_desc_lbl = new MetroFramework.Controls.MetroLabel();
            this.my_title_lbl = new MetroFramework.Controls.MetroLabel();
            this.my_kaluts_lst = new System.Windows.Forms.ListBox();
            this.onlineQuizes_tab = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.all_desk_lbl = new MetroFramework.Controls.MetroLabel();
            this.all_name_lbl = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.all_kaluts_lst = new System.Windows.Forms.ListBox();
            this.favQuiz_tab = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.myfav_desc_lbl = new MetroFramework.Controls.MetroLabel();
            this.myfav_name_lbl = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.myfav_kaluts_lst = new System.Windows.Forms.ListBox();
            this.back_btn = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.myQuizes_tab.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.onlineQuizes_tab.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.favQuiz_tab.SuspendLayout();
            this.metroPanel3.SuspendLayout();
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
            this.metroTabControl1.Multiline = true;
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(697, 407);
            this.metroTabControl1.TabIndex = 0;
            // 
            // myQuizes_tab
            // 
            this.myQuizes_tab.Controls.Add(this.metroPanel1);
            this.myQuizes_tab.Controls.Add(this.my_kaluts_lst);
            this.myQuizes_tab.HorizontalScrollbarBarColor = true;
            this.myQuizes_tab.Location = new System.Drawing.Point(4, 35);
            this.myQuizes_tab.Name = "myQuizes_tab";
            this.myQuizes_tab.Size = new System.Drawing.Size(689, 368);
            this.myQuizes_tab.Style = MetroFramework.MetroColorStyle.Blue;
            this.myQuizes_tab.TabIndex = 0;
            this.myQuizes_tab.Text = "My Kaluts";
            this.myQuizes_tab.VerticalScrollbarBarColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.my_start_kalut_btn);
            this.metroPanel1.Controls.Add(this.my_desc_lbl);
            this.metroPanel1.Controls.Add(this.my_title_lbl);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(443, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(237, 368);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // my_start_kalut_btn
            // 
            this.my_start_kalut_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.my_start_kalut_btn.Highlight = true;
            this.my_start_kalut_btn.Location = new System.Drawing.Point(4, 342);
            this.my_start_kalut_btn.Name = "my_start_kalut_btn";
            this.my_start_kalut_btn.Size = new System.Drawing.Size(230, 23);
            this.my_start_kalut_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.my_start_kalut_btn.TabIndex = 4;
            this.my_start_kalut_btn.Text = "Start!";
            this.my_start_kalut_btn.Click += new System.EventHandler(this.my_start_kalut_btn_Click);
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
            this.my_kaluts_lst.Size = new System.Drawing.Size(443, 368);
            this.my_kaluts_lst.TabIndex = 2;
            this.my_kaluts_lst.SelectedValueChanged += new System.EventHandler(this.my_kaluts_lst_SelectedValueChanged);
            // 
            // onlineQuizes_tab
            // 
            this.onlineQuizes_tab.Controls.Add(this.metroPanel2);
            this.onlineQuizes_tab.Controls.Add(this.all_kaluts_lst);
            this.onlineQuizes_tab.HorizontalScrollbarBarColor = true;
            this.onlineQuizes_tab.Location = new System.Drawing.Point(4, 35);
            this.onlineQuizes_tab.Name = "onlineQuizes_tab";
            this.onlineQuizes_tab.Size = new System.Drawing.Size(689, 368);
            this.onlineQuizes_tab.TabIndex = 1;
            this.onlineQuizes_tab.Text = "Kaluts Made by Other People";
            this.onlineQuizes_tab.VerticalScrollbarBarColor = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.all_desk_lbl);
            this.metroPanel2.Controls.Add(this.all_name_lbl);
            this.metroPanel2.Controls.Add(this.metroButton1);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(443, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(237, 368);
            this.metroPanel2.TabIndex = 5;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            this.metroPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel2_Paint);
            // 
            // all_desk_lbl
            // 
            this.all_desk_lbl.AutoSize = true;
            this.all_desk_lbl.Location = new System.Drawing.Point(6, 29);
            this.all_desk_lbl.Name = "all_desk_lbl";
            this.all_desk_lbl.Size = new System.Drawing.Size(74, 19);
            this.all_desk_lbl.TabIndex = 6;
            this.all_desk_lbl.Text = "Description";
            // 
            // all_name_lbl
            // 
            this.all_name_lbl.AutoSize = true;
            this.all_name_lbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.all_name_lbl.Location = new System.Drawing.Point(6, 4);
            this.all_name_lbl.Name = "all_name_lbl";
            this.all_name_lbl.Size = new System.Drawing.Size(58, 25);
            this.all_name_lbl.TabIndex = 5;
            this.all_name_lbl.Text = "Name";
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(4, 342);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(230, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Start!";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 3;
            // 
            // all_kaluts_lst
            // 
            this.all_kaluts_lst.Dock = System.Windows.Forms.DockStyle.Left;
            this.all_kaluts_lst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_kaluts_lst.FormattingEnabled = true;
            this.all_kaluts_lst.ItemHeight = 18;
            this.all_kaluts_lst.Location = new System.Drawing.Point(0, 0);
            this.all_kaluts_lst.Name = "all_kaluts_lst";
            this.all_kaluts_lst.Size = new System.Drawing.Size(443, 368);
            this.all_kaluts_lst.TabIndex = 4;
            this.all_kaluts_lst.SelectedIndexChanged += new System.EventHandler(this.all_kaluts_lst_SelectedIndexChanged);
            // 
            // favQuiz_tab
            // 
            this.favQuiz_tab.Controls.Add(this.metroPanel3);
            this.favQuiz_tab.Controls.Add(this.myfav_kaluts_lst);
            this.favQuiz_tab.HorizontalScrollbarBarColor = true;
            this.favQuiz_tab.Location = new System.Drawing.Point(4, 35);
            this.favQuiz_tab.Name = "favQuiz_tab";
            this.favQuiz_tab.Size = new System.Drawing.Size(689, 368);
            this.favQuiz_tab.TabIndex = 2;
            this.favQuiz_tab.Text = "My Favorite Kaluts";
            this.favQuiz_tab.VerticalScrollbarBarColor = true;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.myfav_desc_lbl);
            this.metroPanel3.Controls.Add(this.myfav_name_lbl);
            this.metroPanel3.Controls.Add(this.metroButton2);
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(443, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(237, 368);
            this.metroPanel3.TabIndex = 6;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // myfav_desc_lbl
            // 
            this.myfav_desc_lbl.AutoSize = true;
            this.myfav_desc_lbl.Location = new System.Drawing.Point(6, 29);
            this.myfav_desc_lbl.Name = "myfav_desc_lbl";
            this.myfav_desc_lbl.Size = new System.Drawing.Size(74, 19);
            this.myfav_desc_lbl.TabIndex = 6;
            this.myfav_desc_lbl.Text = "Description";
            this.myfav_desc_lbl.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // myfav_name_lbl
            // 
            this.myfav_name_lbl.AutoSize = true;
            this.myfav_name_lbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.myfav_name_lbl.Location = new System.Drawing.Point(6, 4);
            this.myfav_name_lbl.Name = "myfav_name_lbl";
            this.myfav_name_lbl.Size = new System.Drawing.Size(58, 25);
            this.myfav_name_lbl.TabIndex = 5;
            this.myfav_name_lbl.Text = "Name";
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(4, 342);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(230, 23);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "Start!";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(4, 29);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(0, 0);
            this.metroLabel4.TabIndex = 3;
            // 
            // myfav_kaluts_lst
            // 
            this.myfav_kaluts_lst.Dock = System.Windows.Forms.DockStyle.Left;
            this.myfav_kaluts_lst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myfav_kaluts_lst.FormattingEnabled = true;
            this.myfav_kaluts_lst.ItemHeight = 18;
            this.myfav_kaluts_lst.Location = new System.Drawing.Point(0, 0);
            this.myfav_kaluts_lst.Name = "myfav_kaluts_lst";
            this.myfav_kaluts_lst.Size = new System.Drawing.Size(443, 368);
            this.myfav_kaluts_lst.TabIndex = 5;
            this.myfav_kaluts_lst.SelectedIndexChanged += new System.EventHandler(this.myfav_kaluts_lst_SelectedIndexChanged);
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
            this.myQuizes_tab.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.onlineQuizes_tab.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.favQuiz_tab.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage myQuizes_tab;
        private MetroFramework.Controls.MetroTabPage onlineQuizes_tab;
        private MetroFramework.Controls.MetroTabPage favQuiz_tab;
        private MetroFramework.Controls.MetroButton back_btn;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.ListBox my_kaluts_lst;
        private MetroFramework.Controls.MetroLabel my_title_lbl;
        private MetroFramework.Controls.MetroLabel my_desc_lbl;
        private MetroFramework.Controls.MetroButton my_start_kalut_btn;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListBox all_kaluts_lst;
        private MetroFramework.Controls.MetroLabel all_desk_lbl;
        private MetroFramework.Controls.MetroLabel all_name_lbl;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel myfav_desc_lbl;
        private MetroFramework.Controls.MetroLabel myfav_name_lbl;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ListBox myfav_kaluts_lst;
    }
}