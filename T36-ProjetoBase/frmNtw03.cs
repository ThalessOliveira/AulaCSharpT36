using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.VisualBasic;

namespace T36_ProjetoBase
{
    public partial class frmNtw03 : Form
    {

        private string conexao =
ConfigurationManager.ConnectionStrings[1].ConnectionString;
        public frmNtw03()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void carregaGrid()
        {
            string sql = "SELECT * FROM Customers";

            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                dgvDados.DataSource = table;
                lblStatus.Text = dgvDados.RowCount + " transportadoras sendo exibidas";
                limpaCaixas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void limpaCaixas()
        {
            foreach (Control control in Controls)
            {
                // Verifica se o controle é um TextBox
                if (control is TextBox textBox)
                {
                    // Limpa o conteúdo do TextBox
                    textBox.Clear();
                }
            }

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnCreate.Enabled = true;
        }


    }
}
