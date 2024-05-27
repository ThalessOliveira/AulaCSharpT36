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
            uC9AlgorítmosToolStripMenuItem = new ToolStripMenuItem();
            exercício01ToolStripMenuItem = new ToolStripMenuItem();
            exercício02ToolStripMenuItem = new ToolStripMenuItem();
            exercício03ToolStripMenuItem = new ToolStripMenuItem();
            exercício04ToolStripMenuItem = new ToolStripMenuItem();
            exercício05ToolStripMenuItem = new ToolStripMenuItem();
            uC10BancoNorthwindToolStripMenuItem = new ToolStripMenuItem();
            fecharToolStripMenuItem = new ToolStripMenuItem();
            ntw01ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { uC9AlgorítmosToolStripMenuItem, uC10BancoNorthwindToolStripMenuItem, fecharToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // uC9AlgorítmosToolStripMenuItem
            // 
            uC9AlgorítmosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exercício01ToolStripMenuItem, exercício02ToolStripMenuItem, exercício03ToolStripMenuItem, exercício04ToolStripMenuItem, exercício05ToolStripMenuItem });
            uC9AlgorítmosToolStripMenuItem.Name = "uC9AlgorítmosToolStripMenuItem";
            uC9AlgorítmosToolStripMenuItem.Size = new Size(167, 29);
            uC9AlgorítmosToolStripMenuItem.Text = "UC9 - Algorítmos";
            // 
            // exercício01ToolStripMenuItem
            // 
            exercício01ToolStripMenuItem.Name = "exercício01ToolStripMenuItem";
            exercício01ToolStripMenuItem.Size = new Size(270, 34);
            exercício01ToolStripMenuItem.Text = "Exercício 01";
            exercício01ToolStripMenuItem.Click += exercício01ToolStripMenuItem_Click;
            // 
            // exercício02ToolStripMenuItem
            // 
            exercício02ToolStripMenuItem.Name = "exercício02ToolStripMenuItem";
            exercício02ToolStripMenuItem.Size = new Size(270, 34);
            exercício02ToolStripMenuItem.Text = "Exercício 02";
            exercício02ToolStripMenuItem.Click += exercício02ToolStripMenuItem_Click;
            // 
            // exercício03ToolStripMenuItem
            // 
            exercício03ToolStripMenuItem.Name = "exercício03ToolStripMenuItem";
            exercício03ToolStripMenuItem.Size = new Size(270, 34);
            exercício03ToolStripMenuItem.Text = "Exercício 03";
            exercício03ToolStripMenuItem.Click += exercício03ToolStripMenuItem_Click;
            // 
            // exercício04ToolStripMenuItem
            // 
            exercício04ToolStripMenuItem.Name = "exercício04ToolStripMenuItem";
            exercício04ToolStripMenuItem.Size = new Size(270, 34);
            exercício04ToolStripMenuItem.Text = "Exercício 04";
            exercício04ToolStripMenuItem.Click += exercício04ToolStripMenuItem_Click;
            // 
            // exercício05ToolStripMenuItem
            // 
            exercício05ToolStripMenuItem.Name = "exercício05ToolStripMenuItem";
            exercício05ToolStripMenuItem.Size = new Size(270, 34);
            exercício05ToolStripMenuItem.Text = "Exercício 05";
            exercício05ToolStripMenuItem.Click += exercício05ToolStripMenuItem_Click;
            // 
            // uC10BancoNorthwindToolStripMenuItem
            // 
            uC10BancoNorthwindToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ntw01ToolStripMenuItem });
            uC10BancoNorthwindToolStripMenuItem.Name = "uC10BancoNorthwindToolStripMenuItem";
            uC10BancoNorthwindToolStripMenuItem.Size = new Size(225, 29);
            uC10BancoNorthwindToolStripMenuItem.Text = "UC10 - Banco Northwind";
            // 
            // fecharToolStripMenuItem
            // 
            fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            fecharToolStripMenuItem.Size = new Size(79, 29);
            fecharToolStripMenuItem.Text = "Fechar";
            fecharToolStripMenuItem.Click += fecharToolStripMenuItem_Click;
            // 
            // ntw01ToolStripMenuItem
            // 
            ntw01ToolStripMenuItem.Name = "ntw01ToolStripMenuItem";
            ntw01ToolStripMenuItem.Size = new Size(270, 34);
            ntw01ToolStripMenuItem.Text = "Ntw 01";
            ntw01ToolStripMenuItem.Click += ntw01ToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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
        private ToolStripMenuItem uC9AlgorítmosToolStripMenuItem;
        private ToolStripMenuItem exercício01ToolStripMenuItem;
        private ToolStripMenuItem exercício02ToolStripMenuItem;
        private ToolStripMenuItem uC10BancoNorthwindToolStripMenuItem;
        private ToolStripMenuItem fecharToolStripMenuItem;
        private ToolStripMenuItem exercício03ToolStripMenuItem;
        private ToolStripMenuItem exercício04ToolStripMenuItem;
        private ToolStripMenuItem exercício05ToolStripMenuItem;
        private ToolStripMenuItem ntw01ToolStripMenuItem;
    }
}