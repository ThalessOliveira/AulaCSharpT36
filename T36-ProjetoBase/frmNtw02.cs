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
    public partial class frmNtw02 : Form
    {
        private string conexao =
ConfigurationManager.ConnectionStrings[1].ConnectionString;

        public frmNtw02()
        {
            InitializeComponent();
        }

        private void frmNtw02_Load(object sender, EventArgs e)
        {
            //carregaGrid();
        }

        private void carregaGrid()
        {
            string sql = "SELECT CategoryID, CategoryName, Description FROM Categories";

            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                dgvDados.DataSource = table;
                lblStatus.Text = dgvDados.RowCount + " categorias sendo exibidas";
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

        private void carregaGrid(string filtro)
        {
            // Consulta SQL com o operador LIKE para filtrar os dados em vários campos
            string sql = "SELECT * FROM Shippers WHERE CAST(ShipperID AS NVARCHAR) + " +
                "CompanyName + Phone LIKE @Filtro";

            // Estabelecer a conexão com o banco de dados
            SqlConnection con = new SqlConnection(conexao);

            // Criar um comando SQL
            SqlCommand cmd = new SqlCommand(sql, con);

            // Adicionar parâmetro para o filtro
            cmd.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");

            try
            {
                // Abrir a conexão
                con.Open();

                // Criar um DataTable para armazenar os resultados da consulta
                DataTable table = new DataTable();

                // Carregar os dados da consulta para o DataTable
                table.Load(cmd.ExecuteReader());

                // Definir o DataTable como a fonte de dados do DataGridView
                dgvDados.DataSource = table;
                lblStatus.Text = dgvDados.RowCount + " transportadoras sendo exibidas";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao filtrar dados: " + ex.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                // Fechar a conexão no bloco finally para garantir que seja sempre fechada
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvDados.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvDados.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTelefone.Text = dgvDados.Rows[e.RowIndex].Cells[2].Value.ToString();

            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnCreate.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja Realmente Excluir o Registro?", "Confirmação", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Excluir(int.Parse(txtCodigo.Text));
                carregaGrid();
            }
        }

        private void Excluir(int Codigo)
        {
            //Comando SQL para deletar um Shipper
            string sql = "DELETE FROM Categories WHERE CategoryID = @Codigo";

            // Estabelecer a conexão com o banco de dados
            SqlConnection connection = new SqlConnection(conexao);
            connection.Open();

            // Criar um comando SQL
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Codigo", Codigo);


            // Executar o comando SQL
            int rowsAffected = command.ExecuteNonQuery();

            // Verificar se o DELETE foi bem-sucedido
            if (rowsAffected > 0)
            {
                MessageBox.Show("Registro excluído com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Falha ao excluir registro.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Atualizar(int.Parse(txtCodigo.Text), txtNome.Text, txtTelefone.Text);
            carregaGrid();
        }

        private void Atualizar(int codigo, string CategoryName, string Descricao)
        {
            // Comando SQL para inserir um novo Shipper
            string sql = "UPDATE Categories SET CategoryName = @CategoryName, Description = @Descricao WHERE CategoryID = @Codigo";

            // Estabelecer a conexão com o banco de dados
            SqlConnection connection = new SqlConnection(conexao);
            connection.Open();

            // Criar um comando SQL
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CategoryName", CategoryName);
            command.Parameters.AddWithValue("@Descricao", Descricao);
            command.Parameters.AddWithValue("@Codigo", codigo);

            // Executar o comando SQL
            int rowsAffected = command.ExecuteNonQuery();

            // Verificar se o INSERT foi bem-sucedido
            if (rowsAffected > 0)
            {
                MessageBox.Show("Registro atualizado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Falha ao atualizar registro.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Fechar a conexão
            connection.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            carregaGrid();
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

        private void Inserir(string CategoryName, string Description)
        {
            // Comando SQL para inserir um novo Shipper
            string sql = "INSERT INTO Categories (CategoryName, Description) VALUES " +
                "(@CategoryName, @Description)";

            // Estabelecer a conexão com o banco de dados
            SqlConnection connection = new SqlConnection(conexao);
            connection.Open();

            // Criar um comando SQL
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CategoryName", CategoryName);
            command.Parameters.AddWithValue("@Description", Description);

            // Executar o comando SQL
            int rowsAffected = command.ExecuteNonQuery();

            // Verificar se o INSERT foi bem-sucedido
            if (rowsAffected > 0)
            {
                MessageBox.Show("Registro inserido com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Falha ao inserir registro.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Fechar a conexão
            connection.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string descricao = txtTelefone.Text.Trim();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(descricao))
            {
                MessageBox.Show("Por favor, insira valores válidos para Nome e Telefone.",
                    "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Inserir(txtNome.Text, txtTelefone.Text);
            carregaGrid();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            carregaGrid(txtPesquisa.Text);
        }
    }
}
