using System;
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
    public partial class Numeros : Form
    {
        public Numeros()
        {
            InitializeComponent();
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            Número0 numeroCero = new Número0();
            numeroCero.ShowDialog();
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            Numero1 numeroUno = new Numero1();
            numeroUno.ShowDialog();
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            Numero2 numeroDos = new Numero2();
            numeroDos.ShowDialog();
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            Numero3 numeroTres = new Numero3();
            numeroTres.ShowDialog();
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            Numero4 numeroCuatro = new Numero4();
            numeroCuatro.ShowDialog();
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            Numero5 numeroCinco = new Numero5();
            numeroCinco.ShowDialog();
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            Numero6 numeroSeis = new Numero6();
            numeroSeis.ShowDialog();
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            Numero7 numeroSiete = new Numero7();
            numeroSiete.ShowDialog();
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            Numero8 numeroOcho = new Numero8();
            numeroOcho.ShowDialog();
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            Numero9 numeroNueve = new Numero9();
            numeroNueve.ShowDialog();
        }

        private void btnDiez_Click(object sender, EventArgs e)
        {
            Numero10 numeroDiez = new Numero10();
            numeroDiez.ShowDialog();
        }
    }
}
