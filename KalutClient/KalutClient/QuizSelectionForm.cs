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
    public partial class QuizSelectionForm : MetroForm
    {
        WelcomeScreen parent;
        public QuizSelectionForm(WelcomeScreen parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void QuizSelectionForm_Load(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Hide();
            parent.Show();
        }

        private void QuizSelectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0x0);
        }
    }
}
