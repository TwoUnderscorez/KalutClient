namespace KalutClient
{
    partial class WaitForPlayersView
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pin_lbl = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.playesr_txt = new MetroFramework.Controls.MetroTextBox();
            this.start_btn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(149, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Welcome to Kalut!";
            // 
            // pin_lbl
            // 
            this.pin_lbl.AutoSize = true;
            this.pin_lbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.pin_lbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.pin_lbl.Location = new System.Drawing.Point(301, 26);
            this.pin_lbl.Name = "pin_lbl";
            this.pin_lbl.Size = new System.Drawing.Size(52, 25);
            this.pin_lbl.TabIndex = 1;
            this.pin_lbl.Text = "1000";
            this.pin_lbl.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(3, 25);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(301, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "To join this quiz use the following pin: ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(4, 54);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(57, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Players: ";
            // 
            // playesr_txt
            // 
            this.playesr_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playesr_txt.BackColor = System.Drawing.Color.White;
            this.playesr_txt.CustomBackground = true;
            this.playesr_txt.Location = new System.Drawing.Point(67, 54);
            this.playesr_txt.Multiline = true;
            this.playesr_txt.Name = "playesr_txt";
            this.playesr_txt.Size = new System.Drawing.Size(286, 136);
            this.playesr_txt.Style = MetroFramework.MetroColorStyle.White;
            this.playesr_txt.TabIndex = 4;
            this.playesr_txt.UseStyleColors = true;
            // 
            // start_btn
            // 
            this.start_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.start_btn.Highlight = true;
            this.start_btn.Location = new System.Drawing.Point(278, 196);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 23);
            this.start_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.start_btn.TabIndex = 5;
            this.start_btn.Text = "Start!";
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // WaitForPlayersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.playesr_txt);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.pin_lbl);
            this.Controls.Add(this.metroLabel1);
            this.Name = "WaitForPlayersView";
            this.Size = new System.Drawing.Size(359, 222);
            this.Load += new System.EventHandler(this.WaitForPlayersView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        internal MetroFramework.Controls.MetroLabel pin_lbl;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        internal MetroFramework.Controls.MetroTextBox playesr_txt;
        private MetroFramework.Controls.MetroButton start_btn;
    }
}
