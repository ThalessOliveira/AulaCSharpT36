using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T36_ProjetoBase
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void exercicio01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio01 frm = new frmExercicio01();
            frm.ShowDialog();
        }

        private void exercicio02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio02 frm = new frmExercicio02();
            frm.ShowDialog();
        }

        private void fECHARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void exercicio03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio03 frm = new frmExercicio03();
            frm.ShowDialog();
        }

        private void exercicio04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio04 frm = new frmExercicio04();
            frm.ShowDialog();
        }

        private void exercicio05ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio05 frm = new frmExercicio05();
            frm.ShowDialog();
        }
    }
}
