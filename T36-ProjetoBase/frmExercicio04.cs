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

        private void button1_Click(object sender, EventArgs e)
        {
            double tempCelsius, tempFah, tempKel;
            string clima;

            clima = "Fresco";

            tempCelsius = Double.Parse(txtCelsius.Text);

            tempFah = tempCelsius * 1.8 + 32;

            tempKel = tempCelsius + 273;

            if (tempCelsius > 40)
            {
                clima = "Calor";
            }
            else
            {
                if (tempCelsius < 10)
                {
                    clima = "Frio";
                }
            }

            MessageBox.Show("A temperatura em Fahrenheit: " + tempFah.ToString()+"\n" +
                "A temperatura em Kelvin: "+ tempKel.ToString() + "\n" +
                "Hoje está " + clima,"Resultado",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
