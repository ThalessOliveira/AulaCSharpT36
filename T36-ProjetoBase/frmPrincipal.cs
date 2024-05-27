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

        private void exercício01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio01 tela01 = new frmExercicio01();
            tela01.ShowDialog();
        }

        private void exercício02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio02 tela02 = new frmExercicio02();
            tela02.ShowDialog();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exercício03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio03 tela03 = new frmExercicio03();
            tela03.ShowDialog();
        }

        private void exercício04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio04 tela04 = new frmExercicio04();
            tela04.ShowDialog();
        }

        private void exercício05ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio05 tela05 = new frmExercicio05();
            tela05.ShowDialog();
        }

        private void ntw01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNtw01 tela01 = new frmNtw01();
            tela01.ShowDialog();
        }
    }
}
