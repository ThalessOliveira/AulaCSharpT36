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
    public partial class frmExercicio04 : Form
    {
        public frmExercicio04()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            // Declaração das variáveis
            double temperaturaC, temperaturaF, temperaturaK;

            // Entrada de dados
            temperaturaC = Convert.ToDouble(txtCelsius.Text);

            // Processamento
            temperaturaF = (temperaturaC * 1.8) + 32;
            temperaturaK = temperaturaC + 273.15;

            // Saída de dados em uma única MessageBox
            MessageBox.Show("A temperatura em Celsius é: " + temperaturaC.ToString("0.00") + Environment.NewLine +
                            "A temperatura em Fahrenheit é: " + temperaturaF.ToString("0.00") + Environment.NewLine +
                            "A temperatura em Kelvin é: " + temperaturaK.ToString("0.00") + Environment.NewLine +
                            (temperaturaC <= 10 ? "Hoje está FRIO!" : "") + Environment.NewLine +
                            (temperaturaC >= 40 ? "Hoje está CALOR!" : ""), "Resultado", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
