﻿using EjerciciosLibroCSharpCap5_8.git.Capitulo5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosLibroCSharpCap5_8.git
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularFactorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio4 ej4 = new Ejercicio4();
            ej4.Show();
        }
    }
}
