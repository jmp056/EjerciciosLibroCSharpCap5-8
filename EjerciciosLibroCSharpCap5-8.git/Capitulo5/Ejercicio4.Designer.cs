namespace EjerciciosLibroCSharpCap5_8.git.Capitulo5
{
    partial class Ejercicio4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio4));
            this.CalcularButton = new System.Windows.Forms.Button();
            this.FactorialTextBox = new System.Windows.Forms.TextBox();
            this.NumeroNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Factorial = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CalcularButton
            // 
            this.CalcularButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularButton.Image = ((System.Drawing.Image)(resources.GetObject("CalcularButton.Image")));
            this.CalcularButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CalcularButton.Location = new System.Drawing.Point(120, 13);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(105, 23);
            this.CalcularButton.TabIndex = 0;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // FactorialTextBox
            // 
            this.FactorialTextBox.Enabled = false;
            this.FactorialTextBox.Location = new System.Drawing.Point(63, 95);
            this.FactorialTextBox.Name = "FactorialTextBox";
            this.FactorialTextBox.Size = new System.Drawing.Size(110, 20);
            this.FactorialTextBox.TabIndex = 1;
            // 
            // NumeroNumericUpDown
            // 
            this.NumeroNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroNumericUpDown.Location = new System.Drawing.Point(15, 14);
            this.NumeroNumericUpDown.Name = "NumeroNumericUpDown";
            this.NumeroNumericUpDown.Size = new System.Drawing.Size(99, 22);
            this.NumeroNumericUpDown.TabIndex = 2;
            // 
            // Factorial
            // 
            this.Factorial.AutoSize = true;
            this.Factorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Factorial.Location = new System.Drawing.Point(12, 59);
            this.Factorial.Name = "Factorial";
            this.Factorial.Size = new System.Drawing.Size(213, 16);
            this.Factorial.TabIndex = 3;
            this.Factorial.Text = "El Factorial de su numero es: ";
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 133);
            this.Controls.Add(this.Factorial);
            this.Controls.Add(this.NumeroNumericUpDown);
            this.Controls.Add(this.FactorialTextBox);
            this.Controls.Add(this.CalcularButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ejercicio4";
            this.Text = "Culcula Factorial";
            ((System.ComponentModel.ISupportInitialize)(this.NumeroNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.TextBox FactorialTextBox;
        private System.Windows.Forms.NumericUpDown NumeroNumericUpDown;
        private System.Windows.Forms.Label Factorial;
    }
}