﻿namespace T36_ProjetoBase
{
    partial class frmExercicio01
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblResultado = new Label();
            lblStatus = new Label();
            btnCalcular = new Button();
            txtN4 = new TextBox();
            txtN3 = new TextBox();
            txtN2 = new TextBox();
            txtN1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(81, 345);
            lblResultado.Margin = new Padding(4, 0, 4, 0);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(154, 25);
            lblResultado.TabIndex = 12;
            lblResultado.Text = "Resultado : ______";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.Location = new Point(81, 303);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(122, 25);
            lblStatus.TabIndex = 13;
            lblStatus.Text = "Status : ______";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(81, 229);
            btnCalcular.Margin = new Padding(4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(349, 51);
            btnCalcular.TabIndex = 15;
            btnCalcular.Text = "Calcular a Média";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtN4
            // 
            txtN4.Location = new Point(273, 174);
            txtN4.Margin = new Padding(4);
            txtN4.Name = "txtN4";
            txtN4.Size = new Size(155, 31);
            txtN4.TabIndex = 14;
            // 
            // txtN3
            // 
            txtN3.Location = new Point(273, 129);
            txtN3.Margin = new Padding(4);
            txtN3.Name = "txtN3";
            txtN3.Size = new Size(155, 31);
            txtN3.TabIndex = 11;
            // 
            // txtN2
            // 
            txtN2.Location = new Point(273, 84);
            txtN2.Margin = new Padding(4);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(155, 31);
            txtN2.TabIndex = 10;
            // 
            // txtN1
            // 
            txtN1.Location = new Point(273, 39);
            txtN1.Margin = new Padding(4);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(155, 31);
            txtN1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 180);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(164, 25);
            label4.TabIndex = 6;
            label4.Text = "Informe a 4ª Nota: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 133);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(164, 25);
            label3.TabIndex = 7;
            label3.Text = "Informe a 3ª Nota: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 85);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(164, 25);
            label2.TabIndex = 8;
            label2.Text = "Informe a 2ª Nota: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(164, 25);
            label1.TabIndex = 9;
            label1.Text = "Informe a 1ª Nota: ";
            // 
            // frmExercicio01
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 414);
            Controls.Add(lblResultado);
            Controls.Add(lblStatus);
            Controls.Add(btnCalcular);
            Controls.Add(txtN4);
            Controls.Add(txtN3);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmExercicio01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exercício 01";
            Load += frmExercicio01_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblResultado;
        private Label lblStatus;
        private Button btnCalcular;
        private TextBox txtN4;
        private TextBox txtN3;
        private TextBox txtN2;
        private TextBox txtN1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
