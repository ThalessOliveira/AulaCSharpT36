using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace T36_ProjetoBase
{
    public partial class frmNtw01 : Form
    {
        private string conexao =
ConfigurationManager.ConnectionStrings[1].ConnectionString;

        public frmNtw01()
        {
            InitializeComponent();
        }

        private void frmNtw01_Load(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void carregaGrid()
        {
            string sql = "SELECT * FROM Shippers";

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
    }
}
