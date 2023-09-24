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
    public partial class Numero8 : Form
    {
        public Numero8()
        {
            InitializeComponent();
        }

        private void btnNumOchoClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNumOchoBack_Click(object sender, EventArgs e)
        {
            Numero7 numeroSiete = new Numero7();
            numeroSiete.ShowDialog();
            this.Close();
        }

        private void btnNumOchoNext_Click(object sender, EventArgs e)
        {
            Numero9 numeroNueve = new Numero9();
            numeroNueve.ShowDialog();
            this.Close();
        }
    }
}
