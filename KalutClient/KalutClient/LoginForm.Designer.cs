namespace KalutClient
{
    partial class LoginForm
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
            this.login_btn = new MetroFramework.Controls.MetroButton();
            this.close_btn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.usr_txt = new MetroFramework.Controls.MetroTextBox();
            this.pwd_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.register_lnk = new MetroFramework.Controls.MetroLink();
            this.fpwd_lnk = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.Highlight = true;
            this.login_btn.Location = new System.Drawing.Point(23, 209);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(171, 23);
            this.login_btn.Style = MetroFramework.MetroColorStyle.Blue;
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "Log in";
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(200, 209);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(42, 23);
            this.close_btn.TabIndex = 1;
            this.close_btn.Text = "Close";
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Username:";
            // 
            // usr_txt
            // 
            this.usr_txt.Location = new System.Drawing.Point(23, 82);
            this.usr_txt.Name = "usr_txt";
            this.usr_txt.Size = new System.Drawing.Size(219, 23);
            this.usr_txt.Style = MetroFramework.MetroColorStyle.Blue;
            this.usr_txt.TabIndex = 3;
            this.usr_txt.UseStyleColors = true;
            // 
            // pwd_txt
            // 
            this.pwd_txt.Location = new System.Drawing.Point(23, 151);
            this.pwd_txt.Name = "pwd_txt";
            this.pwd_txt.PasswordChar = '●';
            this.pwd_txt.Size = new System.Drawing.Size(219, 23);
            this.pwd_txt.Style = MetroFramework.MetroColorStyle.Blue;
            this.pwd_txt.TabIndex = 5;
            this.pwd_txt.UseStyleColors = true;
            this.pwd_txt.UseSystemPasswordChar = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 129);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Password:";
            // 
            // register_lnk
            // 
            this.register_lnk.Location = new System.Drawing.Point(19, 106);
            this.register_lnk.Name = "register_lnk";
            this.register_lnk.Size = new System.Drawing.Size(223, 16);
            this.register_lnk.Style = MetroFramework.MetroColorStyle.Blue;
            this.register_lnk.TabIndex = 6;
            this.register_lnk.Text = "Not a user? Register!";
            this.register_lnk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.register_lnk.UseStyleColors = true;
            // 
            // fpwd_lnk
            // 
            this.fpwd_lnk.Location = new System.Drawing.Point(19, 174);
            this.fpwd_lnk.Name = "fpwd_lnk";
            this.fpwd_lnk.Size = new System.Drawing.Size(223, 16);
            this.fpwd_lnk.Style = MetroFramework.MetroColorStyle.Blue;
            this.fpwd_lnk.TabIndex = 7;
            this.fpwd_lnk.Text = "Forgot your password?";
            this.fpwd_lnk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fpwd_lnk.UseStyleColors = true;
            this.fpwd_lnk.Click += new System.EventHandler(this.fpwd_lnk_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 243);
            this.ControlBox = false;
            this.Controls.Add(this.fpwd_lnk);
            this.Controls.Add(this.register_lnk);
            this.Controls.Add(this.pwd_txt);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.usr_txt);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.login_btn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Resizable = false;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton login_btn;
        private MetroFramework.Controls.MetroButton close_btn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox usr_txt;
        private MetroFramework.Controls.MetroTextBox pwd_txt;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLink register_lnk;
        private MetroFramework.Controls.MetroLink fpwd_lnk;
    }
}