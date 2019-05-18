namespace EjerciciosLibroCSharpCap5_8.git
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.capitulo4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularFactorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capitulo8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relojToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variasCadnasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capitulo4ToolStripMenuItem,
            this.capitulo8ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // capitulo4ToolStripMenuItem
            // 
            this.capitulo4ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularFactorialToolStripMenuItem});
            this.capitulo4ToolStripMenuItem.Name = "capitulo4ToolStripMenuItem";
            this.capitulo4ToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.capitulo4ToolStripMenuItem.Text = "Capitulo 4";
            // 
            // calcularFactorialToolStripMenuItem
            // 
            this.calcularFactorialToolStripMenuItem.Name = "calcularFactorialToolStripMenuItem";
            this.calcularFactorialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calcularFactorialToolStripMenuItem.Text = "Calcular Factorial";
            this.calcularFactorialToolStripMenuItem.Click += new System.EventHandler(this.CalcularFactorialToolStripMenuItem_Click);
            // 
            // capitulo8ToolStripMenuItem
            // 
            this.capitulo8ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relojToolStripMenuItem,
            this.variasCadnasToolStripMenuItem});
            this.capitulo8ToolStripMenuItem.Name = "capitulo8ToolStripMenuItem";
            this.capitulo8ToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.capitulo8ToolStripMenuItem.Text = "Capitulo 8";
            // 
            // relojToolStripMenuItem
            // 
            this.relojToolStripMenuItem.Name = "relojToolStripMenuItem";
            this.relojToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relojToolStripMenuItem.Text = "Reloj";
            this.relojToolStripMenuItem.Click += new System.EventHandler(this.RelojToolStripMenuItem_Click);
            // 
            // variasCadnasToolStripMenuItem
            // 
            this.variasCadnasToolStripMenuItem.Name = "variasCadnasToolStripMenuItem";
            this.variasCadnasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.variasCadnasToolStripMenuItem.Text = "Varias Cadenas";
            this.variasCadnasToolStripMenuItem.Click += new System.EventHandler(this.VariasCadnasToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem capitulo4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularFactorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capitulo8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relojToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variasCadnasToolStripMenuItem;
    }
}

