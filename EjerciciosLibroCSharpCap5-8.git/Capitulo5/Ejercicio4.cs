using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosLibroCSharpCap5_8.git.Capitulo5
{
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            string f = "";
            double r = 1, n = Convert.ToInt32(NumeroNumericUpDown.Value);
            for (int x = 1; x <= n; x++)
                r *= x;
            f = Convert.ToString(r);
            FactorialTextBox.Text = f;
        }
    }
}
