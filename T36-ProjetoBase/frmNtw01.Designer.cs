namespace T36_ProjetoBase
{
    partial class frmNtw01
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
            dgvDados = new DataGridView();
            lblStatus = new Label();
            txtPesquisa = new TextBox();
            label4 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSelect = new Button();
            btnCreate = new Button();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtCodigo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // dgvDados
            // 
            dgvDados.AllowUserToAddRows = false;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(33, 206);
            dgvDados.Margin = new Padding(2);
            dgvDados.Name = "dgvDados";
            dgvDados.RowHeadersWidth = 62;
            dgvDados.RowTemplate.Height = 33;
            dgvDados.Size = new Size(573, 146);
            dgvDados.TabIndex = 0;
            dgvDados.CellClick += dgvDados_CellClick;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.Blue;
            lblStatus.Location = new Point(33, 184);
            lblStatus.Margin = new Padding(2, 0, 2, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(16, 15);
            lblStatus.TabIndex = 23;
            lblStatus.Text = "...";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(407, 184);
            txtPesquisa.Margin = new Padding(2);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(199, 23);
            txtPesquisa.TabIndex = 22;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(341, 185);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 21;
            label4.Text = "Pesquisa: ";
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(452, 115);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(154, 29);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete ( DELETE )";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(452, 81);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(154, 29);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update ( UPDATE )";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(452, 47);
            btnSelect.Margin = new Padding(3, 2, 3, 2);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(154, 29);
            btnSelect.TabIndex = 18;
            btnSelect.Text = "Read ( SELECT )";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(452, 14);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(154, 29);
            btnCreate.TabIndex = 17;
            btnCreate.Text = "Create ( INSERT )";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(33, 91);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(362, 23);
            txtNome.TabIndex = 15;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(33, 140);
            txtTelefone.Margin = new Padding(3, 2, 3, 2);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(154, 23);
            txtTelefone.TabIndex = 16;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(33, 40);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(110, 23);
            txtCodigo.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 118);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 12;
            label3.Text = "Telefone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 68);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 13;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 17);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 14;
            label1.Text = "Código";
            // 
            // frmNtw01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 377);
            Controls.Add(lblStatus);
            Controls.Add(txtPesquisa);
            Controls.Add(label4);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSelect);
            Controls.Add(btnCreate);
            Controls.Add(txtNome);
            Controls.Add(txtTelefone);
            Controls.Add(txtCodigo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDados);
            Margin = new Padding(2);
            Name = "frmNtw01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Transportadoras";
            Load += frmNtw01_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDados;
        private Label lblStatus;
        private TextBox txtPesquisa;
        private Label label4;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSelect;
        private Button btnCreate;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtCodigo;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}