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
        private double maior = double.MinValue;
        private double menor = double.MaxValue;
        public frmExercicio05()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Add(txtFrase.Text);
            resetarFrase(txtFrase);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            resetarLista(lstResultado);
            resetarFrase(txtFrase);
        }

        void resetarFrase(TextBox caixa)
        {
            caixa.Text = string.Empty;
            caixa.Focus();
        }

        private void btnRemoveLine_Click(object sender, EventArgs e)
        {
            if (lstResultado.Items.Count > 0)
            {
                // Remove o último item da ListBox
                lstResultado.Items.RemoveAt(lstResultado.Items.Count - 1);
            }
        }

        void resetarTabuada()
        {
            lstTabResult.Items.Clear();
            txtTabuada.Clear();
            txtTabuada.Focus();
        }

        void resetarLista(ListBox lista)
        {
            lista.Items.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int tabuada, i, result;

            tabuada = int.Parse(txtTabuada.Text);

            resetarTabuada();

            for (i = 1; i <= 10; ++i)
            {
                result = tabuada * i;
                lstTabResult.Items.Add(+tabuada + " x " + i + " = " + result);
            }

        }

        private void btnCalcFatorial_Click(object sender, EventArgs e)
        {
            int num, i, fatorial;


            num = int.Parse(txtFatorial.Text);

            fatorial = 1;

            resetarFrase(txtFatorial);

            resetarLista(lstFatorial);

            for (i = 1; i <= num; i++)
            {
                fatorial *= i;

                lstFatorial.Items.Add("Calculando o fatorial de: " + i);
            }
            MessageBox.Show("Fatorial é: " + fatorial, "Resultado: ", MessageBoxButtons.OK);
        }

        private void btnAdicionar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btnCalcular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btnCalcFatorial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btnMaiorMenor_Click(object sender, EventArgs e)
        {
            double numero;

            numero = double.Parse(txtMaiorMenor.Text);


            if (numero > maior)
            {
                maior = numero;
            }

            if (numero < menor)
            {
                menor = numero;
            }


            lstMaiorMenor.Items.Add(numero);
            resetarFrase(txtMaiorMenor);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Maior: " + maior + " Menor: " + menor, "Resultado: ");
            resetarFrase(txtMaiorMenor);
            resetarLista(lstMaiorMenor);
        }

        private void btnMaiorMenor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnMaiorMenor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}

