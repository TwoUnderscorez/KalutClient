namespace KalutClient
{
    partial class WallViewHost
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
            this.components = new System.ComponentModel.Container();
            this.status_spn = new MetroFramework.Controls.MetroProgressSpinner();
            this.status_lbl = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // status_spn
            // 
            this.status_spn.Location = new System.Drawing.Point(23, 63);
            this.status_spn.Maximum = 100;
            this.status_spn.Name = "status_spn";
            this.status_spn.Size = new System.Drawing.Size(16, 16);
            this.status_spn.Speed = 3F;
            this.status_spn.TabIndex = 0;
            this.status_spn.Value = 10;
            this.status_spn.Click += new System.EventHandler(this.metroProgressSpinner1_Click);
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.Location = new System.Drawing.Point(45, 60);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(82, 19);
            this.status_lbl.TabIndex = 1;
            this.status_lbl.Text = "Please wait...";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Players: ";
            // 
            // WallViewHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.status_lbl);
            this.Controls.Add(this.status_spn);
            this.Name = "WallViewHost";
            this.Text = "Kalut Game";
            this.Load += new System.EventHandler(this.WallViewHost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner status_spn;
        private MetroFramework.Controls.MetroLabel status_lbl;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
