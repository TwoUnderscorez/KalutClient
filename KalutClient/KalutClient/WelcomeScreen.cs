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
    public partial class WelcomeScreen : MetroForm
    {
        QuizMakerForm qmaker;
        QuizSelectionForm qselector;
        
        public WelcomeScreen()
        {
            InitializeComponent();
            qmaker = new QuizMakerForm(this);
            qselector = new QuizSelectionForm(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Hide();
            qselector.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Hide();
            qmaker.Show();
        }

        private void WelcomeScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0x0);
        }
    }
}
