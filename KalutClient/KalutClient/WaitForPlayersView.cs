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
    public partial class WaitForPlayersView : MetroUserControl
    {
        WallViewHost parent;
        public WaitForPlayersView(WallViewHost parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void WaitForPlayersView_Load(object sender, EventArgs e)
        {

        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            parent.StartButtonClick();
            Hide();
        }
    }
}
