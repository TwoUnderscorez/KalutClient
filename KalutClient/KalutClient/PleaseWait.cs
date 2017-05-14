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
using MetroFramework.Fonts;

namespace KalutClient
{
    public partial class PleaseWait : MetroForm
    {
        public string msg;
        public PleaseWait(string msg)
        {
            InitializeComponent();
            this.msg = msg;
        }

        private void PleaseWait_Load(object sender, EventArgs e)
        {
            metroTextBox1.Text = msg;
        }
    }
}
