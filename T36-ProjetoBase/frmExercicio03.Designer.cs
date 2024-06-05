namespace T36_ProjetoBase
{
    partial class frmExercicio03
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
            btnCalcular = new Button();
            txtAltura = new TextBox();
            txtBase = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(116, 167);
            btnCalcular.Margin = new Padding(4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(349, 51);
            btnCalcular.TabIndex = 14;
            btnCalcular.Text = "Calcular a Área";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(345, 100);
            txtAltura.Margin = new Padding(4);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(155, 31);
            txtAltura.TabIndex = 13;
            // 
            // txtBase
            // 
            txtBase.Location = new Point(345, 54);
            txtBase.Margin = new Padding(4);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(155, 31);
            txtBase.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 101);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(261, 25);
            label2.TabIndex = 11;
            label2.Text = "Informe a ALTURA do Triângulo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 54);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(239, 25);
            label1.TabIndex = 12;
            label1.Text = "Informe a BASE do Triângulo";
            // 
            // frmExercicio03
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 290);
            Controls.Add(btnCalcular);
            Controls.Add(txtAltura);
            Controls.Add(txtBase);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmExercicio03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exercício 03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtAltura;
        private TextBox txtBase;
        private Label label2;
        private Label label1;
    }
}