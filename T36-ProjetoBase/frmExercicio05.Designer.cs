namespace T36_ProjetoBase
{
    partial class frmExercicio05
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
            txtFrase = new TextBox();
            btnAdicionar = new Button();
            btnLimpar = new Button();
            lstResultado = new ListBox();
            lstTabuada = new ListBox();
            btnCalcular = new Button();
            label1 = new Label();
            txtTabuada = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            lstFatorial = new ListBox();
            btnCalcularFatorial = new Button();
            txtNumero = new TextBox();
            label2 = new Label();
            tabPage4 = new TabPage();
            btnVerificar = new Button();
            btnAdd = new Button();
            lstNumMaiorMenor = new ListBox();
            label3 = new Label();
            txtNumMaiorMenor = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // txtFrase
            // 
            txtFrase.Location = new Point(28, 29);
            txtFrase.Name = "txtFrase";
            txtFrase.Size = new Size(436, 31);
            txtFrase.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(28, 86);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(112, 34);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(146, 86);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(112, 34);
            btnLimpar.TabIndex = 2;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 25;
            lstResultado.Location = new Point(28, 150);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(436, 304);
            lstResultado.TabIndex = 3;
            // 
            // lstTabuada
            // 
            lstTabuada.FormattingEnabled = true;
            lstTabuada.ItemHeight = 25;
            lstTabuada.Location = new Point(81, 138);
            lstTabuada.Margin = new Padding(4);
            lstTabuada.Name = "lstTabuada";
            lstTabuada.Size = new Size(313, 329);
            lstTabuada.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(276, 91);
            btnCalcular.Margin = new Padding(4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(118, 36);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(244, 25);
            label1.TabIndex = 6;
            label1.Text = "Informe a Tabuada desejada: ";
            // 
            // txtTabuada
            // 
            txtTabuada.Location = new Point(290, 52);
            txtTabuada.Margin = new Padding(4);
            txtTabuada.Name = "txtTabuada";
            txtTabuada.Size = new Size(104, 31);
            txtTabuada.TabIndex = 4;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(26, 33);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1017, 564);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lstResultado);
            tabPage1.Controls.Add(txtFrase);
            tabPage1.Controls.Add(btnAdicionar);
            tabPage1.Controls.Add(btnLimpar);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1009, 526);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Testando coleções";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lstTabuada);
            tabPage2.Controls.Add(txtTabuada);
            tabPage2.Controls.Add(btnCalcular);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1009, 526);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tabuada";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lstFatorial);
            tabPage3.Controls.Add(btnCalcularFatorial);
            tabPage3.Controls.Add(txtNumero);
            tabPage3.Controls.Add(label2);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1009, 526);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Fatorial";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // lstFatorial
            // 
            lstFatorial.FormattingEnabled = true;
            lstFatorial.ItemHeight = 25;
            lstFatorial.Location = new Point(73, 185);
            lstFatorial.Margin = new Padding(4);
            lstFatorial.Name = "lstFatorial";
            lstFatorial.Size = new Size(488, 254);
            lstFatorial.TabIndex = 7;
            // 
            // btnCalcularFatorial
            // 
            btnCalcularFatorial.Location = new Point(332, 106);
            btnCalcularFatorial.Margin = new Padding(4);
            btnCalcularFatorial.Name = "btnCalcularFatorial";
            btnCalcularFatorial.Size = new Size(230, 51);
            btnCalcularFatorial.TabIndex = 6;
            btnCalcularFatorial.Text = "Calcular Fatorial";
            btnCalcularFatorial.UseVisualStyleBackColor = true;
            btnCalcularFatorial.Click += btnCalcularFatorial_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(474, 44);
            txtNumero.Margin = new Padding(4);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(86, 31);
            txtNumero.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 41);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(359, 25);
            label2.TabIndex = 4;
            label2.Text = "Informe o número a ser calculado o fatorial:";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnVerificar);
            tabPage4.Controls.Add(btnAdd);
            tabPage4.Controls.Add(lstNumMaiorMenor);
            tabPage4.Controls.Add(label3);
            tabPage4.Controls.Add(txtNumMaiorMenor);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1009, 526);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Número Maior e Menor";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(237, 123);
            btnVerificar.Margin = new Padding(4);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(246, 36);
            btnVerificar.TabIndex = 8;
            btnVerificar.Text = "Verificar o Maior e Menor ";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(365, 53);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 36);
            btnAdd.TabIndex = 5;
            btnAdd.Text = ">>>";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstNumMaiorMenor
            // 
            lstNumMaiorMenor.FormattingEnabled = true;
            lstNumMaiorMenor.ItemHeight = 25;
            lstNumMaiorMenor.Location = new Point(549, 53);
            lstNumMaiorMenor.Margin = new Padding(4);
            lstNumMaiorMenor.Name = "lstNumMaiorMenor";
            lstNumMaiorMenor.Size = new Size(163, 404);
            lstNumMaiorMenor.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 59);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(170, 25);
            label3.TabIndex = 6;
            label3.Text = "Informe o Número: ";
            // 
            // txtNumMaiorMenor
            // 
            txtNumMaiorMenor.Location = new Point(237, 56);
            txtNumMaiorMenor.Margin = new Padding(4);
            txtNumMaiorMenor.Name = "txtNumMaiorMenor";
            txtNumMaiorMenor.Size = new Size(120, 31);
            txtNumMaiorMenor.TabIndex = 4;
            // 
            // frmExercicio05
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 638);
            Controls.Add(tabControl1);
            KeyPreview = true;
            Name = "frmExercicio05";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exercício 05";
            KeyDown += frmExercicio05_KeyDown;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtFrase;
        private Button btnAdicionar;
        private Button btnLimpar;
        private ListBox lstResultado;
        private ListBox lstTabuada;
        private Button btnCalcular;
        private Label label1;
        private TextBox txtTabuada;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ListBox lstFatorial;
        private Button btnCalcularFatorial;
        private TextBox txtNumero;
        private Label label2;
        private TabPage tabPage4;
        private Button btnVerificar;
        private Button btnAdd;
        private ListBox lstNumMaiorMenor;
        private Label label3;
        private TextBox txtNumMaiorMenor;
    }
}