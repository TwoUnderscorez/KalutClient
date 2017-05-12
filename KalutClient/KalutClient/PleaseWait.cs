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
            metroLabel1.Text = msg;
        }
    }
}
