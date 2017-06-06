namespace KalutClient
{
    partial class Register
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
            this.usrname_txt = new MetroFramework.Controls.MetroTextBox();
            this.pwd_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.repawd_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.register_btn = new MetroFramework.Controls.MetroButton();
            this.cancel_btn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Username:";
            // 
            // usrname_txt
            // 
            this.usrname_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usrname_txt.Location = new System.Drawing.Point(24, 87);
            this.usrname_txt.Name = "usrname_txt";
            this.usrname_txt.Size = new System.Drawing.Size(237, 23);
            this.usrname_txt.Style = MetroFramework.MetroColorStyle.Blue;
            this.usrname_txt.TabIndex = 1;
            this.usrname_txt.UseStyleColors = true;
            // 
            // pwd_txt
            // 
            this.pwd_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pwd_txt.Location = new System.Drawing.Point(23, 137);
            this.pwd_txt.Name = "pwd_txt";
            this.pwd_txt.PasswordChar = '●';
            this.pwd_txt.Size = new System.Drawing.Size(237, 23);
            this.pwd_txt.Style = MetroFramework.MetroColorStyle.Blue;
            this.pwd_txt.TabIndex = 3;
            this.pwd_txt.UseStyleColors = true;
            this.pwd_txt.UseSystemPasswordChar = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 114);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Password:";
            // 
            // repawd_txt
            // 
            this.repawd_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.repawd_txt.Location = new System.Drawing.Point(24, 187);
            this.repawd_txt.Name = "repawd_txt";
            this.repawd_txt.PasswordChar = '●';
            this.repawd_txt.Size = new System.Drawing.Size(237, 23);
            this.repawd_txt.Style = MetroFramework.MetroColorStyle.Blue;
            this.repawd_txt.TabIndex = 5;
            this.repawd_txt.UseStyleColors = true;
            this.repawd_txt.UseSystemPasswordChar = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 164);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(112, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Repeat password:";
            // 
            // register_btn
            // 
            this.register_btn.Highlight = true;
            this.register_btn.Location = new System.Drawing.Point(24, 216);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(183, 23);
            this.register_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.register_btn.TabIndex = 6;
            this.register_btn.Text = "Register!";
            this.register_btn.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(213, 216);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(47, 23);
            this.cancel_btn.TabIndex = 7;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.repawd_txt);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.pwd_txt);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.usrname_txt);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox usrname_txt;
        private MetroFramework.Controls.MetroTextBox pwd_txt;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox repawd_txt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton register_btn;
        private MetroFramework.Controls.MetroButton cancel_btn;
    }
}