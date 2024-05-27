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
            dgvDados.Location = new Point(47, 343);
            dgvDados.Name = "dgvDados";
            dgvDados.RowHeadersWidth = 62;
            dgvDados.RowTemplate.Height = 33;
            dgvDados.Size = new Size(818, 244);
            dgvDados.TabIndex = 0;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.Blue;
            lblStatus.Location = new Point(47, 306);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(24, 25);
            lblStatus.TabIndex = 23;
            lblStatus.Text = "...";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(582, 306);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(283, 31);
            txtPesquisa.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(487, 309);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 21;
            label4.Text = "Pesquisa: ";
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(645, 192);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(220, 49);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete ( DELETE )";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(645, 135);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(220, 49);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update ( UPDATE )";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(645, 79);
            btnSelect.Margin = new Padding(4);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(220, 49);
            btnSelect.TabIndex = 18;
            btnSelect.Text = "Read ( SELECT )";
            btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(645, 23);
            btnCreate.Margin = new Padding(4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(220, 49);
            btnCreate.TabIndex = 17;
            btnCreate.Text = "Create ( INSERT )";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(47, 151);
            txtNome.Margin = new Padding(4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(516, 31);
            txtNome.TabIndex = 15;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(47, 234);
            txtTelefone.Margin = new Padding(4);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(219, 31);
            txtTelefone.TabIndex = 16;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(47, 67);
            txtCodigo.Margin = new Padding(4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(155, 31);
            txtCodigo.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(47, 197);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 12;
            label3.Text = "Telefone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(47, 113);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 13;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(47, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 14;
            label1.Text = "Código";
            // 
            // frmNtw01
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 628);
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