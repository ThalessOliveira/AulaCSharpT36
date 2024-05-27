namespace T36_ProjetoBase
{
    partial class frmExercicio04
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
            pictureBox1 = new PictureBox();
            btnConverter = new Button();
            txtCelsius = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.termometro;
            pictureBox1.Location = new Point(201, 65);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnConverter
            // 
            btnConverter.BackColor = Color.FromArgb(255, 192, 128);
            btnConverter.Location = new Point(141, 364);
            btnConverter.Margin = new Padding(4);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(295, 44);
            btnConverter.TabIndex = 7;
            btnConverter.Text = "Converter Temperatura";
            btnConverter.UseVisualStyleBackColor = false;
            btnConverter.Click += btnConverter_Click;
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(226, 304);
            txtCelsius.Margin = new Padding(4);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(124, 31);
            txtCelsius.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(192, 64, 0);
            label2.Location = new Point(141, 275);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(284, 25);
            label2.TabIndex = 5;
            label2.Text = "Informe a temperatura em Celsius:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(125, 219);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(318, 32);
            label1.TabIndex = 6;
            label1.Text = "Conversor de Temperatura";
            // 
            // frmExercicio04
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 472);
            Controls.Add(pictureBox1);
            Controls.Add(btnConverter);
            Controls.Add(txtCelsius);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmExercicio04";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exercício 04";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnConverter;
        private TextBox txtCelsius;
        private Label label2;
        private Label label1;
    }
}