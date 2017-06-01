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
using MetroFramework.Forms;

namespace KalutClient
{
    public partial class JoinKalutView : MetroUserControl
    {
        PlayerViewHost parent;
        public JoinKalutView(PlayerViewHost parent)
        {
            InitializeComponent();
            this.parent = parent; 
        }

        private void JoinKalutView_Load(object sender, EventArgs e)
        {

        }

        private void JoinKalut_btn_Click(object sender, EventArgs e)
        {
            parent.JoinKalut_Press();
        }
    }
}
