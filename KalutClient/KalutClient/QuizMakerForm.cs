using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace KalutClient
{
    public partial class QuizMakerForm : MetroForm
    {
        WelcomeScreen parent;
        public QuizMakerForm(WelcomeScreen parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void QuizMakerFormcs_Load(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            parent.Show();
            Hide();
        }

        private void QuizMakerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0x0);
        }
    }
}
