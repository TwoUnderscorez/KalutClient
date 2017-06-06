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
    public partial class QuizEditorHost : MetroForm
    {
        QuizEditor editor;
        int uid;
        public QuizEditorHost(int uid)
        {
            InitializeComponent();
            this.uid = uid;
        }

        private void QuizEditorHost_Load(object sender, EventArgs e)
        {
            editor = new QuizEditor(false, uid, this);
            Controls.Add(editor);
            editor.Dock = DockStyle.Fill;
            editor.LoadQuizData();
        }
    }
}
