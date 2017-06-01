namespace KalutClient
{
    partial class JoinKalutView
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
            this.screen_name_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.PIN_txt = new System.Windows.Forms.NumericUpDown();
            this.JoinKalut_btn = new MetroFramework.Controls.MetroButton();
            this.err_lbl = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PIN_txt)).BeginInit();
            this.SuspendLayout();
            // 
            // screen_name_txt
            // 
            this.screen_name_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.screen_name_txt.Location = new System.Drawing.Point(3, 22);
            this.screen_name_txt.Name = "screen_name_txt";
            this.screen_name_txt.Size = new System.Drawing.Size(144, 23);
            this.screen_name_txt.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 48);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(33, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "PIN:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(0, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Screen name:";
            // 
            // PIN_txt
            // 
            this.PIN_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PIN_txt.Location = new System.Drawing.Point(3, 70);
            this.PIN_txt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PIN_txt.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PIN_txt.Name = "PIN_txt";
            this.PIN_txt.Size = new System.Drawing.Size(144, 20);
            this.PIN_txt.TabIndex = 6;
            this.PIN_txt.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // JoinKalut_btn
            // 
            this.JoinKalut_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.JoinKalut_btn.Highlight = true;
            this.JoinKalut_btn.Location = new System.Drawing.Point(72, 124);
            this.JoinKalut_btn.Name = "JoinKalut_btn";
            this.JoinKalut_btn.Size = new System.Drawing.Size(75, 23);
            this.JoinKalut_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.JoinKalut_btn.TabIndex = 7;
            this.JoinKalut_btn.Text = "Join";
            this.JoinKalut_btn.Click += new System.EventHandler(this.JoinKalut_btn_Click);
            // 
            // err_lbl
            // 
            this.err_lbl.AutoSize = true;
            this.err_lbl.Location = new System.Drawing.Point(3, 93);
            this.err_lbl.Name = "err_lbl";
            this.err_lbl.Size = new System.Drawing.Size(0, 0);
            this.err_lbl.Style = MetroFramework.MetroColorStyle.Red;
            this.err_lbl.TabIndex = 8;
            this.err_lbl.UseStyleColors = true;
            // 
            // JoinKalutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.err_lbl);
            this.Controls.Add(this.JoinKalut_btn);
            this.Controls.Add(this.PIN_txt);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.screen_name_txt);
            this.Name = "JoinKalutView";
            this.Load += new System.EventHandler(this.JoinKalutView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PIN_txt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton JoinKalut_btn;
        internal MetroFramework.Controls.MetroTextBox screen_name_txt;
        internal System.Windows.Forms.NumericUpDown PIN_txt;
        internal MetroFramework.Controls.MetroLabel err_lbl;
    }
}
