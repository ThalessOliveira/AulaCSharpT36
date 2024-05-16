namespace T36_ProjetoBase
{
    public partial class frmExercicio01 : Form
    {
        public frmExercicio01()
        {
            InitializeComponent();
        }

        private void frmExercicio01_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Aqui vamos codificar o clique do bot�o
            // Declara��o das vari�veis
            double n1, n2, n3, n4, m;

            // Entrada
            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            n3 = double.Parse(txtN3.Text);
            n4 = double.Parse(txtN4.Text);

            // Processamento
            m = (n1 + n2 + n3 + n4) / 4;

            if (m >= 7)
            {
                lblStatus.Text = "Status: APROVADO";
                lblStatus.ForeColor = Color.Blue;
            }
            else
            {
                lblStatus.Text = "Status: REPROVADO";
                lblStatus.ForeColor = Color.Red;
            }

            // Sa�da
            lblResultado.Text = "A m�dia das notas equivale � " + m.ToString("N2");

        }
    }
}
