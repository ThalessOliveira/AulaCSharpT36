namespace T36_ProjetoBase
{
    partial class frmNtw03
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStatus = new Label();
            txtPesquisa = new TextBox();
            label4 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSelect = new Button();
            btnCreate = new Button();
            txtNome = new TextBox();
            txtContato = new TextBox();
            txtCodigo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvDados = new DataGridView();
            txtTitulo = new TextBox();
            label5 = new Label();
            txtEndereço = new TextBox();
            label6 = new Label();
            txtCidade = new TextBox();
            label7 = new Label();
            txtRegiao = new TextBox();
            label8 = new Label();
            txtCodPost = new TextBox();
            label9 = new Label();
            txtPais = new TextBox();
            label10 = new Label();
            txtTelefone = new TextBox();
            label11 = new Label();
            txtFax = new TextBox();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.Blue;
            lblStatus.Location = new Point(43, 234);
            lblStatus.Margin = new Padding(2, 0, 2, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(16, 15);
            lblStatus.TabIndex = 51;
            lblStatus.Text = "...";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(418, 234);
            txtPesquisa.Margin = new Padding(2);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(199, 23);
            txtPesquisa.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 236);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 49;
            label4.Text = "Pesquisa: ";
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(462, 119);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(154, 29);
            btnDelete.TabIndex = 48;
            btnDelete.Text = "Delete ( DELETE )";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(462, 85);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(154, 29);
            btnUpdate.TabIndex = 47;
            btnUpdate.Text = "Update ( UPDATE )";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(462, 52);
            btnSelect.Margin = new Padding(3, 2, 3, 2);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(154, 29);
            btnSelect.TabIndex = 46;
            btnSelect.Text = "Read ( SELECT )";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(462, 18);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(154, 29);
            btnCreate.TabIndex = 45;
            btnCreate.Text = "Create ( INSERT )";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(43, 95);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(110, 23);
            txtNome.TabIndex = 43;
            // 
            // txtContato
            // 
            txtContato.Location = new Point(43, 145);
            txtContato.Margin = new Padding(3, 2, 3, 2);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(110, 23);
            txtContato.TabIndex = 44;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(43, 44);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(110, 23);
            txtCodigo.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(43, 122);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 40;
            label3.Text = "Contato";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(43, 72);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 41;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(43, 22);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 42;
            label1.Text = "Código";
            // 
            // dgvDados
            // 
            dgvDados.AllowUserToAddRows = false;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(43, 256);
            dgvDados.Margin = new Padding(2);
            dgvDados.Name = "dgvDados";
            dgvDados.RowHeadersWidth = 62;
            dgvDados.RowTemplate.Height = 33;
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.Size = new Size(573, 146);
            dgvDados.TabIndex = 38;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(175, 44);
            txtTitulo.Margin = new Padding(3, 2, 3, 2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(110, 23);
            txtTitulo.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(175, 21);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 52;
            label5.Text = "Titulo";
            // 
            // txtEndereço
            // 
            txtEndereço.Location = new Point(175, 95);
            txtEndereço.Margin = new Padding(3, 2, 3, 2);
            txtEndereço.Name = "txtEndereço";
            txtEndereço.Size = new Size(110, 23);
            txtEndereço.TabIndex = 55;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(175, 72);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 54;
            label6.Text = "Endereço";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(175, 145);
            txtCidade.Margin = new Padding(3, 2, 3, 2);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(110, 23);
            txtCidade.TabIndex = 57;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(175, 122);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 56;
            label7.Text = "Cidade";
            // 
            // txtRegiao
            // 
            txtRegiao.Location = new Point(309, 44);
            txtRegiao.Margin = new Padding(3, 2, 3, 2);
            txtRegiao.Name = "txtRegiao";
            txtRegiao.Size = new Size(110, 23);
            txtRegiao.TabIndex = 59;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(309, 21);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 58;
            label8.Text = "Região";
            // 
            // txtCodPost
            // 
            txtCodPost.Location = new Point(309, 95);
            txtCodPost.Margin = new Padding(3, 2, 3, 2);
            txtCodPost.Name = "txtCodPost";
            txtCodPost.Size = new Size(110, 23);
            txtCodPost.TabIndex = 61;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(309, 72);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 60;
            label9.Text = "Cód. Postal";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(309, 145);
            txtPais.Margin = new Padding(3, 2, 3, 2);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(110, 23);
            txtPais.TabIndex = 63;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(309, 122);
            label10.Name = "label10";
            label10.Size = new Size(28, 15);
            label10.TabIndex = 62;
            label10.Text = "País";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(43, 198);
            txtTelefone.Margin = new Padding(3, 2, 3, 2);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(110, 23);
            txtTelefone.TabIndex = 65;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(43, 175);
            label11.Name = "label11";
            label11.Size = new Size(56, 15);
            label11.TabIndex = 64;
            label11.Text = "Telefone";
            // 
            // txtFax
            // 
            txtFax.Location = new Point(175, 198);
            txtFax.Margin = new Padding(3, 2, 3, 2);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(110, 23);
            txtFax.TabIndex = 67;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(175, 175);
            label12.Name = "label12";
            label12.Size = new Size(26, 15);
            label12.TabIndex = 66;
            label12.Text = "Fax";
            // 
            // frmNtw03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 413);
            Controls.Add(txtFax);
            Controls.Add(label12);
            Controls.Add(txtTelefone);
            Controls.Add(label11);
            Controls.Add(txtPais);
            Controls.Add(label10);
            Controls.Add(txtCodPost);
            Controls.Add(label9);
            Controls.Add(txtRegiao);
            Controls.Add(label8);
            Controls.Add(txtCidade);
            Controls.Add(label7);
            Controls.Add(txtEndereço);
            Controls.Add(label6);
            Controls.Add(txtTitulo);
            Controls.Add(label5);
            Controls.Add(lblStatus);
            Controls.Add(txtPesquisa);
            Controls.Add(label4);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSelect);
            Controls.Add(btnCreate);
            Controls.Add(txtNome);
            Controls.Add(txtContato);
            Controls.Add(txtCodigo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDados);
            Name = "frmNtw03";
            Text = "Cadastro de Clientes";
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private TextBox txtPesquisa;
        private Label label4;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSelect;
        private Button btnCreate;
        private TextBox txtNome;
        private TextBox txtContato;
        private TextBox txtCodigo;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvDados;
        private TextBox txtTitulo;
        private Label label5;
        private TextBox txtEndereço;
        private Label label6;
        private TextBox txtCidade;
        private Label label7;
        private TextBox txtRegiao;
        private Label label8;
        private TextBox txtCodPost;
        private Label label9;
        private TextBox txtPais;
        private Label label10;
        private TextBox txtTelefone;
        private Label label11;
        private TextBox txtFax;
        private Label label12;
    }
}