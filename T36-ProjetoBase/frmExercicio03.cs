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
    public partial class frmExercicio03 : Form
    {
        public frmExercicio03()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double b, a, area;

            b = double.Parse(txtBase.Text);
            a = double.Parse(txtAltura.Text);

            area = (b * a) / 2;

            MessageBox.Show("A área do triângulo é de " + area.ToString("N2"),
            "Resultado do Cálculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
