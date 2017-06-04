namespace KalutClient
{
    partial class PlayerViewHost
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
            this.components = new System.ComponentModel.Container();
            this.status_spn = new MetroFramework.Controls.MetroProgressSpinner();
            this.status_lbl = new MetroFramework.Controls.MetroTextBox();
            this.QuestionTimeout_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // status_spn
            // 
            this.status_spn.Location = new System.Drawing.Point(23, 63);
            this.status_spn.Maximum = 100;
            this.status_spn.Name = "status_spn";
            this.status_spn.Size = new System.Drawing.Size(16, 16);
            this.status_spn.TabIndex = 1;
            // 
            // status_lbl
            // 
            this.status_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.status_lbl.CustomBackground = true;
            this.status_lbl.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.status_lbl.Location = new System.Drawing.Point(45, 56);
            this.status_lbl.Multiline = true;
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(235, 182);
            this.status_lbl.Style = MetroFramework.MetroColorStyle.White;
            this.status_lbl.TabIndex = 2;
            this.status_lbl.Text = "Please wait...";
            this.status_lbl.UseStyleColors = true;
            // 
            // QuestionTimeout_timer
            // 
            this.QuestionTimeout_timer.Interval = 1000;
            this.QuestionTimeout_timer.Tick += new System.EventHandler(this.QuestionTimeout_timer_Tick);
            // 
            // PlayerViewHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.status_lbl);
            this.Controls.Add(this.status_spn);
            this.Name = "PlayerViewHost";
            this.Text = "Join a Kalut";
            this.Load += new System.EventHandler(this.PlayerViewHost_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroProgressSpinner status_spn;
        private MetroFramework.Controls.MetroTextBox status_lbl;
        private System.Windows.Forms.Timer QuestionTimeout_timer;
    }
}