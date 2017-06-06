namespace KalutClient
{
    partial class AnsweredView
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.correct_lbl = new MetroFramework.Controls.MetroLabel();
            this.points_lbl = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(104, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "your asnwer was";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 23);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "You have ";
            // 
            // correct_lbl
            // 
            this.correct_lbl.AutoSize = true;
            this.correct_lbl.Location = new System.Drawing.Point(105, 0);
            this.correct_lbl.Name = "correct_lbl";
            this.correct_lbl.Size = new System.Drawing.Size(30, 19);
            this.correct_lbl.Style = MetroFramework.MetroColorStyle.Black;
            this.correct_lbl.TabIndex = 2;
            this.correct_lbl.Text = "in/c";
            this.correct_lbl.UseStyleColors = true;
            // 
            // points_lbl
            // 
            this.points_lbl.AutoSize = true;
            this.points_lbl.Location = new System.Drawing.Point(64, 23);
            this.points_lbl.Name = "points_lbl";
            this.points_lbl.Size = new System.Drawing.Size(55, 19);
            this.points_lbl.Style = MetroFramework.MetroColorStyle.Blue;
            this.points_lbl.TabIndex = 3;
            this.points_lbl.Text = "0 points";
            this.points_lbl.UseStyleColors = true;
            // 
            // AnsweredView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.points_lbl);
            this.Controls.Add(this.correct_lbl);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AnsweredView";
            this.Size = new System.Drawing.Size(196, 87);
            this.Load += new System.EventHandler(this.AnsweredView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel correct_lbl;
        private MetroFramework.Controls.MetroLabel points_lbl;
    }
}
