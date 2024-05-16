namespace T36_ProjetoBase
{
    partial class frmLogin
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
            lblTentativas = new Label();
            btnFechar = new Button();
            btnLogar = new Button();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTentativas
            // 
            lblTentativas.AutoSize = true;
            lblTentativas.Location = new Point(107, 369);
            lblTentativas.Margin = new Padding(4, 0, 4, 0);
            lblTentativas.Name = "lblTentativas";
            lblTentativas.Size = new Size(108, 25);
            lblTentativas.TabIndex = 13;
            lblTentativas.Text = "Tentativas: 0";
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(52, 289);
            btnFechar.Margin = new Padding(4, 5, 4, 5);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(211, 56);
            btnFechar.TabIndex = 10;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(52, 222);
            btnLogar.Margin = new Padding(4, 5, 4, 5);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(211, 56);
            btnLogar.TabIndex = 9;
            btnLogar.Text = "Logar";
            btnLogar.UseVisualStyleBackColor = true;
            btnLogar.Click += btnLogar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(52, 150);
            txtSenha.Margin = new Padding(4, 5, 4, 5);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(210, 31);
            txtSenha.TabIndex = 8;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(52, 59);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(210, 31);
            txtUsuario.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 120);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 11;
            label2.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 12;
            label1.Text = "Usuário:";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 440);
            Controls.Add(lblTentativas);
            Controls.Add(btnFechar);
            Controls.Add(btnLogar);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autenticação";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTentativas;
        private Button btnFechar;
        private Button btnLogar;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Label label2;
        private Label label1;
    }
}