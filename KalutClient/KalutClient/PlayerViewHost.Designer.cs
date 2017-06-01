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
            this.status_lbl = new MetroFramework.Controls.MetroLabel();
            this.status_spn = new MetroFramework.Controls.MetroProgressSpinner();
            this.SuspendLayout();
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.Location = new System.Drawing.Point(45, 60);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(82, 19);
            this.status_lbl.TabIndex = 0;
            this.status_lbl.Text = "Please wait...";
            // 
            // status_spn
            // 
            this.status_spn.Location = new System.Drawing.Point(23, 63);
            this.status_spn.Maximum = 100;
            this.status_spn.Name = "status_spn";
            this.status_spn.Size = new System.Drawing.Size(16, 16);
            this.status_spn.TabIndex = 1;
            // 
            // PlayerViewHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.status_spn);
            this.Controls.Add(this.status_lbl);
            this.Name = "PlayerViewHost";
            this.Text = "Join a Kalut";
            this.Load += new System.EventHandler(this.PlayerViewHost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel status_lbl;
        private MetroFramework.Controls.MetroProgressSpinner status_spn;
    }
}