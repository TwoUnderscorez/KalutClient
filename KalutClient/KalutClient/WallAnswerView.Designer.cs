namespace KalutClient
{
    partial class WallAnswerView
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
            this.ans2_tile = new MetroFramework.Controls.MetroTile();
            this.ans1_tile = new MetroFramework.Controls.MetroTile();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.question_txt = new MetroFramework.Controls.MetroTextBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.nextq_btn = new MetroFramework.Controls.MetroButton();
            this.show_ans_btn = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ans3_tile
            // 
            this.ans3_tile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ans3_tile.Location = new System.Drawing.Point(3, 3);
            this.ans3_tile.Name = "ans3_tile";
            this.ans3_tile.Size = new System.Drawing.Size(290, 66);
            this.ans3_tile.Style = MetroFramework.MetroColorStyle.Red;
            this.ans3_tile.TabIndex = 0;
            this.ans3_tile.Text = "metroTile1";
            this.ans3_tile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ans0_tile
            // 
            this.ans0_tile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ans0_tile.Location = new System.Drawing.Point(299, 3);
            this.ans0_tile.Name = "ans0_tile";
            this.ans0_tile.Size = new System.Drawing.Size(291, 66);
            this.ans0_tile.Style = MetroFramework.MetroColorStyle.Blue;
            this.ans0_tile.TabIndex = 1;
            this.ans0_tile.Text = "metroTile2";
            this.ans0_tile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ans2_tile
            // 
            this.ans2_tile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ans2_tile.Location = new System.Drawing.Point(3, 75);
            this.ans2_tile.Name = "ans2_tile";
            this.ans2_tile.Size = new System.Drawing.Size(290, 66);
            this.ans2_tile.Style = MetroFramework.MetroColorStyle.Yellow;
            this.ans2_tile.TabIndex = 2;
            this.ans2_tile.Text = "metroTile4";
            this.ans2_tile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ans1_tile
            // 
            this.ans1_tile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ans1_tile.Location = new System.Drawing.Point(299, 75);
            this.ans1_tile.Name = "ans1_tile";
            this.ans1_tile.Size = new System.Drawing.Size(291, 66);
            this.ans1_tile.Style = MetroFramework.MetroColorStyle.Green;
            this.ans1_tile.TabIndex = 3;
            this.ans1_tile.Text = "metroTile3";
            this.ans1_tile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tableLayoutPanel1.TabIndex = 7;
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
            this.question_txt.TabIndex = 6;
            this.question_txt.Text = "metroTextBox1";
            this.question_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.question_txt.UseStyleColors = true;
            // 
            // webBrowser
            // 
            this.webBrowser.AllowNavigation = false;
            this.webBrowser.AllowWebBrowserDrop = false;
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser.Location = new System.Drawing.Point(0, 63);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(593, 113);
            this.webBrowser.TabIndex = 8;
            this.webBrowser.WebBrowserShortcutsEnabled = false;
            // 
            // nextq_btn
            // 
            this.nextq_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextq_btn.Location = new System.Drawing.Point(503, 40);
            this.nextq_btn.Name = "nextq_btn";
            this.nextq_btn.Size = new System.Drawing.Size(87, 23);
            this.nextq_btn.TabIndex = 9;
            this.nextq_btn.Text = "Next Question";
            this.nextq_btn.Click += new System.EventHandler(this.nextq_btn_Click);
            // 
            // show_ans_btn
            // 
            this.show_ans_btn.Location = new System.Drawing.Point(3, 40);
            this.show_ans_btn.Name = "show_ans_btn";
            this.show_ans_btn.Size = new System.Drawing.Size(87, 23);
            this.show_ans_btn.TabIndex = 10;
            this.show_ans_btn.Text = "Reveal answer";
            this.show_ans_btn.Click += new System.EventHandler(this.show_ans_btn_Click);
            // 
            // WallAnswerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.show_ans_btn);
            this.Controls.Add(this.nextq_btn);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.question_txt);
            this.Name = "WallAnswerView";
            this.Size = new System.Drawing.Size(593, 320);
            this.Load += new System.EventHandler(this.WallAnswerView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTextBox question_txt;
        private System.Windows.Forms.WebBrowser webBrowser;
        private MetroFramework.Controls.MetroTile ans3_tile;
        private MetroFramework.Controls.MetroTile ans0_tile;
        private MetroFramework.Controls.MetroTile ans2_tile;
        private MetroFramework.Controls.MetroTile ans1_tile;
        internal MetroFramework.Controls.MetroButton nextq_btn;
        internal MetroFramework.Controls.MetroButton show_ans_btn;
    }
}
