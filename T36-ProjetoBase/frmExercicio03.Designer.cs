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
            label1 = new Label();
            label2 = new Label();
            txtBase = new TextBox();
            txtAltura = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 63);
            label1.Name = "label1";
            label1.Size = new Size(163, 15);
            label1.TabIndex = 0;
            label1.Text = "Informe a BASE do Triângulo: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 128);
            label2.Name = "label2";
            label2.Size = new Size(178, 15);
            label2.TabIndex = 1;
            label2.Text = "Informe a ALTURA do Triângulo: ";
            // 
            // txtBase
            // 
            txtBase.Location = new Point(271, 63);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(100, 23);
            txtBase.TabIndex = 2;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(271, 125);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(161, 194);
            button1.Name = "button1";
            button1.Size = new Size(111, 23);
            button1.TabIndex = 4;
            button1.Text = "Calcular Área";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmExercicio03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 277);
            Controls.Add(button1);
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

        private Label label1;
        private Label label2;
        private TextBox txtBase;
        private TextBox txtAltura;
        private Button button1;
    }
}