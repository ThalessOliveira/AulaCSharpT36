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
    public partial class frmLogin : Form
    {
        int tentativas = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtSenha.Text == "1234")
            {
                frmPrincipal frm = new frmPrincipal();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Usuário e/ou Senha Inválidos", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tentativas++;
                if (tentativas > 3)
                {
                    Application.Exit();
                }
                lblTentativas.Text = "Tentativas: " + tentativas.ToString();
            }
        }
    }
}
