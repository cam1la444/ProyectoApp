﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoApp
{
    public partial class Números : Form
    {
        public Números()
        {
            InitializeComponent();
        }

        private void btnNumCero_Click(object sender, EventArgs e)
        {
            Número0 numeroCero = new Número0();
            numeroCero.ShowDialog();
        }

        private void btnNumUno_Click(object sender, EventArgs e)
        {
            Numero1 numeroUno = new Numero1();
            numeroUno.ShowDialog();
        }
    }
}
