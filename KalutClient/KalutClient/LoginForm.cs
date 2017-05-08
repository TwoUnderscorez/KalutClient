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
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fpwd_lnk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Well that's unfortunate, isn't it?", "Kalut", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
