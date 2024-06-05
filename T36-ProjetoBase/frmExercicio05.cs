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
    public partial class frmExercicio05 : Form
    {
        int contador = 1;
        int maior, menor = 0;

        public frmExercicio05()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Add(txtFrase.Text);
            resetarCaixa(txtFrase);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            resetarCaixa(txtFrase);
        }

        void resetarCaixa(TextBox caixa)
        {
            caixa.Text = string.Empty;
            caixa.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int tabuada = int.Parse(txtTabuada.Text);

            lstTabuada.Items.Clear();

            // REPETIDOR FOR
            //for (int i = 1; i <= 10; i++)
            //{
            //    lstTabuada.Items.Add(tabuada + " x " + i + " = " + i*tabuada);
            //}

            // REPETIDOR WHILE
            int j = 1;
            while (j <= 10)
            {
                lstTabuada.Items.Add(tabuada + " x " + j + " = " + j * tabuada);
                j++;
            }
            resetarCaixa(txtTabuada);
        }

        private void btnCalcularFatorial_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            int fatorial = 1;

            while (numero >= 1)
            {
                fatorial = fatorial * numero;
                lstFatorial.Items.Add("Calculando fatorial de: " + numero);
                numero = numero - 1;
            }

            MessageBox.Show("Fatorial é: " + fatorial.ToString());
        }

        private void frmExercicio05_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int numMaiorMenor = int.Parse(txtNumMaiorMenor.Text);

            if (contador == 1)
            {
                maior = numMaiorMenor;
                menor = numMaiorMenor;
            }
            else
            {
                //if (contador >= 10)
                //{
                //    txtNumMaiorMenor.Enabled = false;
                //}

                if (numMaiorMenor > maior)
                {
                    maior = numMaiorMenor;
                }

                if (numMaiorMenor < menor)
                {
                    menor = numMaiorMenor;
                }

            }

            lstNumMaiorMenor.Items.Add(txtNumMaiorMenor.Text);
            resetarCaixa(txtNumMaiorMenor);
            contador++;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Maior e Menor: " + maior + " " + menor);

            contador = 1;
            txtNumMaiorMenor.Enabled = true;
            lstNumMaiorMenor.Items.Clear();
            maior = 0;
            menor = 0;
        }
    }
}
