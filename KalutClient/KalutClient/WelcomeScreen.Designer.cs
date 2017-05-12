namespace KalutClient
{
    partial class WelcomeScreen
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.login_lnk = new MetroFramework.Controls.MetroLink();
            this.srv_sts_lnk = new MetroFramework.Controls.MetroLink();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "I want to...";
            // 
            // login_lnk
            // 
            this.login_lnk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_lnk.Location = new System.Drawing.Point(97, 60);
            this.login_lnk.Name = "login_lnk";
            this.login_lnk.Size = new System.Drawing.Size(176, 19);
            this.login_lnk.Style = MetroFramework.MetroColorStyle.Blue;
            this.login_lnk.TabIndex = 5;
            this.login_lnk.Text = "Log in";
            this.login_lnk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.login_lnk.UseStyleColors = true;
            this.login_lnk.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // srv_sts_lnk
            // 
            this.srv_sts_lnk.Location = new System.Drawing.Point(1, 301);
            this.srv_sts_lnk.Name = "srv_sts_lnk";
            this.srv_sts_lnk.Size = new System.Drawing.Size(293, 23);
            this.srv_sts_lnk.Style = MetroFramework.MetroColorStyle.Blue;
            this.srv_sts_lnk.TabIndex = 6;
            this.srv_sts_lnk.Text = "Check service status";
            this.srv_sts_lnk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.srv_sts_lnk.UseStyleColors = true;
            this.srv_sts_lnk.Click += new System.EventHandler(this.srv_sts_lnk_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.BackColor = System.Drawing.Color.White;
            this.metroTile4.ForeColor = System.Drawing.Color.Transparent;
            this.metroTile4.Location = new System.Drawing.Point(50, 102);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(196, 102);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile4.TabIndex = 4;
            this.metroTile4.Text = "Join a quiz";
            this.metroTile4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile4.TileImage = global::KalutClient.Properties.Resources.rsz_1rsz_plus_512;
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.UseTileImage = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(151, 210);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(95, 58);
            this.metroTile2.TabIndex = 2;
            this.metroTile2.Text = "Create a quiz";
            this.metroTile2.TileImage = global::KalutClient.Properties.Resources.rsz_notepad;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(50, 210);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(95, 58);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Host a quiz";
            this.metroTile1.TileImage = global::KalutClient.Properties.Resources.rsz_player_copy;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 323);
            this.Controls.Add(this.srv_sts_lnk);
            this.Controls.Add(this.login_lnk);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTile1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(296, 323);
            this.MinimumSize = new System.Drawing.Size(296, 323);
            this.Name = "WelcomeScreen";
            this.Resizable = false;
            this.Text = " Welcome to Kalut!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WelcomeScreen_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroLink login_lnk;
        private MetroFramework.Controls.MetroLink srv_sts_lnk;
    }
}

