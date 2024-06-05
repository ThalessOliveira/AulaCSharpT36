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
    public partial class frmExercicio02 : Form
    {
        public frmExercicio02()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Variáveis
            double Kms, hrs, Vm;

            // Entrada
            Kms = double.Parse(txtKm.Text);
            hrs = double.Parse(txtHr.Text);

            // Processamento
            Vm = Kms / hrs;

            // Saída
            MessageBox.Show("A Velocidade Média é de " + Vm.ToString("N2") + " Km/Hora",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void calcularAreaQuadrado(int lado)
        {
            int area = lado * lado;
        }
    }
}
