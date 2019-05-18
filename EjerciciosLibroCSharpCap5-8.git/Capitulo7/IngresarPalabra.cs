using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosLibroCSharpCap5_8.git.Capitulo7
{
    public partial class IngresarPalabra : Form
    {
        public IngresarPalabra()
        {
            InitializeComponent();
        }

        private void IngresarPalabraButton_Click(object sender, EventArgs e)
        {
            while (PalabraTextBox.Text != string.Empty && SignificadoTextBox.Text == string.Empty)
            {
                if (PalabraTextBox.Text == string.Empty)
                {
                    MyErrorProvider.SetError(PalabraTextBox, "El campo \"Palabra\" no puede estar vacio");
                    PalabraTextBox.Focus();
                }
                if (SignificadoTextBox.Text == string.Empty)
                {
                    MyErrorProvider.SetError(SignificadoTextBox, "El campo \"Significado\" no puede estar vacio");
                    SignificadoTextBox.Focus();
                }
            }
        }
    }
}
