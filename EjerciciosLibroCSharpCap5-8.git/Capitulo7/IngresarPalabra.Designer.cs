namespace EjerciciosLibroCSharpCap5_8.git.Capitulo7
{
    partial class IngresarPalabra
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
            this.components = new System.ComponentModel.Container();
            this.IngresarPalabraButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PalabraTextBox = new System.Windows.Forms.TextBox();
            this.SignificadoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IngresarPalabraButton
            // 
            this.IngresarPalabraButton.Location = new System.Drawing.Point(376, 45);
            this.IngresarPalabraButton.Name = "IngresarPalabraButton";
            this.IngresarPalabraButton.Size = new System.Drawing.Size(125, 23);
            this.IngresarPalabraButton.TabIndex = 2;
            this.IngresarPalabraButton.Text = "Ingresar Palabra";
            this.IngresarPalabraButton.UseVisualStyleBackColor = true;
            this.IngresarPalabraButton.Click += new System.EventHandler(this.IngresarPalabraButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Palabra";
            // 
            // PalabraTextBox
            // 
            this.PalabraTextBox.Location = new System.Drawing.Point(205, 18);
            this.PalabraTextBox.Name = "PalabraTextBox";
            this.PalabraTextBox.Size = new System.Drawing.Size(100, 20);
            this.PalabraTextBox.TabIndex = 4;
            // 
            // SignificadoTextBox
            // 
            this.SignificadoTextBox.Location = new System.Drawing.Point(171, 76);
            this.SignificadoTextBox.Name = "SignificadoTextBox";
            this.SignificadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.SignificadoTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Significado";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // IngresarPalabra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SignificadoTextBox);
            this.Controls.Add(this.PalabraTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IngresarPalabraButton);
            this.Name = "IngresarPalabra";
            this.Text = "IngresarPalabra";
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IngresarPalabraButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PalabraTextBox;
        private System.Windows.Forms.TextBox SignificadoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}