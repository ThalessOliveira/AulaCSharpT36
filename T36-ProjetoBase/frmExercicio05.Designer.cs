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
            btnRemoveLine = new Button();
            label1 = new Label();
            txtTabuada = new TextBox();
            btnCalcular = new Button();
            lstTabResult = new ListBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            btnCalcFatorial = new Button();
            lstFatorial = new ListBox();
            txtFatorial = new TextBox();
            label2 = new Label();
            tabPage4 = new TabPage();
            lstMaiorMenor = new ListBox();
            btnVerifica = new Button();
            btnMaiorMenor = new Button();
            txtMaiorMenor = new TextBox();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // txtFrase
            // 
            txtFrase.Location = new Point(16, 14);
            txtFrase.Name = "txtFrase";
            txtFrase.Size = new Size(370, 23);
            txtFrase.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(16, 53);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            btnAdicionar.KeyDown += btnAdicionar_KeyDown;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(97, 53);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 2;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 15;
            lstResultado.Location = new Point(16, 95);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(370, 94);
            lstResultado.TabIndex = 3;
            // 
            // btnRemoveLine
            // 
            btnRemoveLine.Location = new Point(178, 53);
            btnRemoveLine.Name = "btnRemoveLine";
            btnRemoveLine.Size = new Size(75, 23);
            btnRemoveLine.TabIndex = 4;
            btnRemoveLine.Text = "Remover";
            btnRemoveLine.UseVisualStyleBackColor = true;
            btnRemoveLine.Click += btnRemoveLine_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 26);
            label1.Name = "label1";
            label1.Size = new Size(157, 15);
            label1.TabIndex = 5;
            label1.Text = "Informe a Tabuada desejada:";
            // 
            // txtTabuada
            // 
            txtTabuada.Location = new Point(179, 23);
            txtTabuada.Name = "txtTabuada";
            txtTabuada.Size = new Size(85, 23);
            txtTabuada.TabIndex = 6;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(179, 52);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(85, 23);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            btnCalcular.KeyDown += btnCalcular_KeyDown;
            // 
            // lstTabResult
            // 
            lstTabResult.FormattingEnabled = true;
            lstTabResult.ItemHeight = 15;
            lstTabResult.Location = new Point(16, 81);
            lstTabResult.Name = "lstTabResult";
            lstTabResult.Size = new Size(248, 244);
            lstTabResult.TabIndex = 8;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(2, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(592, 474);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtFrase);
            tabPage1.Controls.Add(lstResultado);
            tabPage1.Controls.Add(btnAdicionar);
            tabPage1.Controls.Add(btnRemoveLine);
            tabPage1.Controls.Add(btnLimpar);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(584, 446);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Testando Coleções";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lstTabResult);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(btnCalcular);
            tabPage2.Controls.Add(txtTabuada);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(584, 446);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tabuada";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnCalcFatorial);
            tabPage3.Controls.Add(lstFatorial);
            tabPage3.Controls.Add(txtFatorial);
            tabPage3.Controls.Add(label2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(584, 446);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Fatorial";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCalcFatorial
            // 
            btnCalcFatorial.Location = new Point(169, 79);
            btnCalcFatorial.Name = "btnCalcFatorial";
            btnCalcFatorial.Size = new Size(158, 40);
            btnCalcFatorial.TabIndex = 3;
            btnCalcFatorial.Text = "Calcular";
            btnCalcFatorial.UseVisualStyleBackColor = true;
            btnCalcFatorial.Click += btnCalcFatorial_Click;
            btnCalcFatorial.KeyDown += btnCalcFatorial_KeyDown;
            // 
            // lstFatorial
            // 
            lstFatorial.FormattingEnabled = true;
            lstFatorial.ItemHeight = 15;
            lstFatorial.Location = new Point(53, 148);
            lstFatorial.Name = "lstFatorial";
            lstFatorial.Size = new Size(274, 109);
            lstFatorial.TabIndex = 2;
            // 
            // txtFatorial
            // 
            txtFatorial.Location = new Point(169, 40);
            txtFatorial.Name = "txtFatorial";
            txtFatorial.Size = new Size(158, 23);
            txtFatorial.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 43);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 0;
            label2.Text = "Digite o número: ";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(lstMaiorMenor);
            tabPage4.Controls.Add(btnVerifica);
            tabPage4.Controls.Add(btnMaiorMenor);
            tabPage4.Controls.Add(txtMaiorMenor);
            tabPage4.Controls.Add(label3);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(584, 446);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Número Maior e Menor";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // lstMaiorMenor
            // 
            lstMaiorMenor.FormattingEnabled = true;
            lstMaiorMenor.ItemHeight = 15;
            lstMaiorMenor.Location = new Point(387, 79);
            lstMaiorMenor.Name = "lstMaiorMenor";
            lstMaiorMenor.Size = new Size(120, 304);
            lstMaiorMenor.TabIndex = 4;
            // 
            // btnVerifica
            // 
            btnVerifica.Location = new Point(155, 108);
            btnVerifica.Name = "btnVerifica";
            btnVerifica.Size = new Size(194, 23);
            btnVerifica.TabIndex = 3;
            btnVerifica.Text = "Verifica o Maior e Menor";
            btnVerifica.UseVisualStyleBackColor = true;
            btnVerifica.Click += button1_Click;
            // 
            // btnMaiorMenor
            // 
            btnMaiorMenor.Location = new Point(261, 79);
            btnMaiorMenor.Name = "btnMaiorMenor";
            btnMaiorMenor.Size = new Size(88, 23);
            btnMaiorMenor.TabIndex = 2;
            btnMaiorMenor.Text = "> > >";
            btnMaiorMenor.UseVisualStyleBackColor = true;
            btnMaiorMenor.Click += btnMaiorMenor_Click;
            btnMaiorMenor.KeyDown += btnMaiorMenor_KeyDown;
            btnMaiorMenor.KeyPress += btnMaiorMenor_KeyPress;
            // 
            // txtMaiorMenor
            // 
            txtMaiorMenor.Location = new Point(155, 79);
            txtMaiorMenor.Name = "txtMaiorMenor";
            txtMaiorMenor.Size = new Size(100, 23);
            txtMaiorMenor.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 82);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 0;
            label3.Text = "Informe o Número: ";
            // 
            // frmExercicio05
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 473);
            Controls.Add(tabControl1);
            KeyPreview = true;
            Name = "frmExercicio05";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exercicio 05";
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
        private Button btnRemoveLine;
        private Label label1;
        private TextBox txtTabuada;
        private Button btnCalcular;
        private ListBox lstTabResult;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btnCalcFatorial;
        private ListBox lstFatorial;
        private TextBox txtFatorial;
        private Label label2;
        private TabPage tabPage4;
        private Label label3;
        private ListBox lstMaiorMenor;
        private Button btnVerifica;
        private Button btnMaiorMenor;
        private TextBox txtMaiorMenor;
    }
}