namespace T36_ProjetoBase
{
    partial class frmPrincipal
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
            menuStrip1 = new MenuStrip();
            uC9ExerciciosToolStripMenuItem = new ToolStripMenuItem();
            exercicio01ToolStripMenuItem = new ToolStripMenuItem();
            exercicio02ToolStripMenuItem = new ToolStripMenuItem();
            exercicio03ToolStripMenuItem = new ToolStripMenuItem();
            exercicio04ToolStripMenuItem = new ToolStripMenuItem();
            uC10ExerciciosToolStripMenuItem = new ToolStripMenuItem();
            fECHARToolStripMenuItem = new ToolStripMenuItem();
            exercicio05ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { uC9ExerciciosToolStripMenuItem, uC10ExerciciosToolStripMenuItem, fECHARToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(497, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // uC9ExerciciosToolStripMenuItem
            // 
            uC9ExerciciosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exercicio01ToolStripMenuItem, exercicio02ToolStripMenuItem, exercicio03ToolStripMenuItem, exercicio04ToolStripMenuItem, exercicio05ToolStripMenuItem });
            uC9ExerciciosToolStripMenuItem.Name = "uC9ExerciciosToolStripMenuItem";
            uC9ExerciciosToolStripMenuItem.Size = new Size(104, 20);
            uC9ExerciciosToolStripMenuItem.Text = "UC9 - Exercicios";
            // 
            // exercicio01ToolStripMenuItem
            // 
            exercicio01ToolStripMenuItem.Name = "exercicio01ToolStripMenuItem";
            exercicio01ToolStripMenuItem.Size = new Size(180, 22);
            exercicio01ToolStripMenuItem.Text = "Exercicio 01";
            exercicio01ToolStripMenuItem.Click += exercicio01ToolStripMenuItem_Click;
            // 
            // exercicio02ToolStripMenuItem
            // 
            exercicio02ToolStripMenuItem.Name = "exercicio02ToolStripMenuItem";
            exercicio02ToolStripMenuItem.Size = new Size(180, 22);
            exercicio02ToolStripMenuItem.Text = "Exercicio 02";
            exercicio02ToolStripMenuItem.Click += exercicio02ToolStripMenuItem_Click;
            // 
            // exercicio03ToolStripMenuItem
            // 
            exercicio03ToolStripMenuItem.Name = "exercicio03ToolStripMenuItem";
            exercicio03ToolStripMenuItem.Size = new Size(180, 22);
            exercicio03ToolStripMenuItem.Text = "Exercicio 03";
            exercicio03ToolStripMenuItem.Click += exercicio03ToolStripMenuItem_Click;
            // 
            // exercicio04ToolStripMenuItem
            // 
            exercicio04ToolStripMenuItem.Name = "exercicio04ToolStripMenuItem";
            exercicio04ToolStripMenuItem.Size = new Size(180, 22);
            exercicio04ToolStripMenuItem.Text = "Exercicio 04";
            exercicio04ToolStripMenuItem.Click += exercicio04ToolStripMenuItem_Click;
            // 
            // uC10ExerciciosToolStripMenuItem
            // 
            uC10ExerciciosToolStripMenuItem.Name = "uC10ExerciciosToolStripMenuItem";
            uC10ExerciciosToolStripMenuItem.Size = new Size(151, 20);
            uC10ExerciciosToolStripMenuItem.Text = "UC10 - Banco Northwind";
            // 
            // fECHARToolStripMenuItem
            // 
            fECHARToolStripMenuItem.Name = "fECHARToolStripMenuItem";
            fECHARToolStripMenuItem.Size = new Size(63, 20);
            fECHARToolStripMenuItem.Text = "FECHAR";
            fECHARToolStripMenuItem.Click += fECHARToolStripMenuItem_Click;
            // 
            // exercicio05ToolStripMenuItem
            // 
            exercicio05ToolStripMenuItem.Name = "exercicio05ToolStripMenuItem";
            exercicio05ToolStripMenuItem.Size = new Size(180, 22);
            exercicio05ToolStripMenuItem.Text = "Exercicio 05";
            exercicio05ToolStripMenuItem.Click += exercicio05ToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(497, 290);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "frmPrincipal";
            Text = "TELA PRINCIPAL DO SISTEMA";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem uC9ExerciciosToolStripMenuItem;
        private ToolStripMenuItem exercicio01ToolStripMenuItem;
        private ToolStripMenuItem exercicio02ToolStripMenuItem;
        private ToolStripMenuItem uC10ExerciciosToolStripMenuItem;
        private ToolStripMenuItem fECHARToolStripMenuItem;
        private ToolStripMenuItem exercicio03ToolStripMenuItem;
        private ToolStripMenuItem exercicio04ToolStripMenuItem;
        private ToolStripMenuItem exercicio05ToolStripMenuItem;
    }
}