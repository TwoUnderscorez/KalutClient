namespace KalutClient
{
    partial class AnswerQuestionView
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
            this.ans3_tile = new MetroFramework.Controls.MetroTile();
            this.ans0_tile = new MetroFramework.Controls.MetroTile();
            this.ans1_tile = new MetroFramework.Controls.MetroTile();
            this.ans2_tile = new MetroFramework.Controls.MetroTile();
            this.question_txt = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timeout_spn = new MetroFramework.Controls.MetroProgressSpinner();
            this.timeout_txt = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ans3_tile
            // 
            this.ans3_tile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ans3_tile.Location = new System.Drawing.Point(3, 3);
            this.ans3_tile.Name = "ans3_tile";
            this.ans3_tile.Size = new System.Drawing.Size(289, 66);
            this.ans3_tile.TabIndex = 0;
            this.ans3_tile.Text = "metroTile1";
            this.ans3_tile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ans3_tile.Click += new System.EventHandler(this.ans3_tile_Click);
            // 
            // ans0_tile
            // 
            this.ans0_tile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ans0_tile.Location = new System.Drawing.Point(301, 3);
            this.ans0_tile.Name = "ans0_tile";
            this.ans0_tile.Size = new System.Drawing.Size(289, 66);
            this.ans0_tile.TabIndex = 1;
            this.ans0_tile.Text = "metroTile2";
            this.ans0_tile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ans0_tile.Click += new System.EventHandler(this.ans0_tile_Click);
            // 
            // ans1_tile
            // 
            this.ans1_tile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ans1_tile.Location = new System.Drawing.Point(299, 75);
            this.ans1_tile.Name = "ans1_tile";
            this.ans1_tile.Size = new System.Drawing.Size(291, 66);
            this.ans1_tile.TabIndex = 3;
            this.ans1_tile.Text = "metroTile3";
            this.ans1_tile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ans1_tile.Click += new System.EventHandler(this.ans1_tile_Click);
            // 
            // ans2_tile
            // 
            this.ans2_tile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ans2_tile.Location = new System.Drawing.Point(3, 75);
            this.ans2_tile.Name = "ans2_tile";
            this.ans2_tile.Size = new System.Drawing.Size(289, 66);
            this.ans2_tile.TabIndex = 2;
            this.ans2_tile.Text = "metroTile4";
            this.ans2_tile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ans2_tile.Click += new System.EventHandler(this.ans2_tile_Click);
            // 
            // question_txt
            // 
            this.question_txt.BackColor = System.Drawing.Color.White;
            this.question_txt.CustomBackground = true;
            this.question_txt.Dock = System.Windows.Forms.DockStyle.Top;
            this.question_txt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.question_txt.Location = new System.Drawing.Point(0, 0);
            this.question_txt.Multiline = true;
            this.question_txt.Name = "question_txt";
            this.question_txt.ReadOnly = true;
            this.question_txt.Size = new System.Drawing.Size(593, 63);
            this.question_txt.Style = MetroFramework.MetroColorStyle.White;
            this.question_txt.TabIndex = 4;
            this.question_txt.Text = "metroTextBox1";
            this.question_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.question_txt.UseStyleColors = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ans3_tile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ans0_tile, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ans2_tile, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ans1_tile, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 176);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(593, 144);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // timeout_spn
            // 
            this.timeout_spn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeout_spn.Location = new System.Drawing.Point(251, 5);
            this.timeout_spn.Maximum = 100;
            this.timeout_spn.Name = "timeout_spn";
            this.timeout_spn.Size = new System.Drawing.Size(104, 104);
            this.timeout_spn.Spinning = false;
            this.timeout_spn.TabIndex = 6;
            this.timeout_spn.TabStop = false;
            // 
            // timeout_txt
            // 
            this.timeout_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeout_txt.CustomBackground = true;
            this.timeout_txt.Location = new System.Drawing.Point(278, 47);
            this.timeout_txt.Name = "timeout_txt";
            this.timeout_txt.Size = new System.Drawing.Size(50, 23);
            this.timeout_txt.Style = MetroFramework.MetroColorStyle.White;
            this.timeout_txt.TabIndex = 7;
            this.timeout_txt.Text = "0";
            this.timeout_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeout_txt.UseStyleColors = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.timeout_txt);
            this.panel1.Controls.Add(this.timeout_spn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 113);
            this.panel1.TabIndex = 8;
            // 
            // AnswerQuestionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.question_txt);
            this.Name = "AnswerQuestionView";
            this.Size = new System.Drawing.Size(593, 320);
            this.Load += new System.EventHandler(this.AnswerQuestionView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile ans3_tile;
        private MetroFramework.Controls.MetroTile ans0_tile;
        private MetroFramework.Controls.MetroTile ans1_tile;
        private MetroFramework.Controls.MetroTile ans2_tile;
        private MetroFramework.Controls.MetroTextBox question_txt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        internal MetroFramework.Controls.MetroProgressSpinner timeout_spn;
        internal MetroFramework.Controls.MetroTextBox timeout_txt;
    }
}
