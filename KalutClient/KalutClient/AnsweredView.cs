using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace KalutClient
{
    public partial class AnsweredView : MetroUserControl
    {
        PlayerViewHost parent;
        public AnsweredView(PlayerViewHost parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void AnsweredView_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        public void Update(string points, bool correct)
        {
            points_lbl.Text = points + "points.";
            if (correct)
            {
                correct_lbl.Style = MetroFramework.MetroColorStyle.Green;
                correct_lbl.Text = "correct!";
            }
            else
            {
                correct_lbl.Style = MetroFramework.MetroColorStyle.Red;
                correct_lbl.Text = "incorrect.";
            }
        }
    }
}
