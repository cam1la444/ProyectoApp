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
    public partial class Numero7 : Form
    {
        public Numero7()
        {
            InitializeComponent();
        }

        private void btnNumSieteClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNumSieteBack_Click(object sender, EventArgs e)
        {
            Numero6 numeroSeis = new Numero6();
            numeroSeis.ShowDialog();
            this.Close();
        }

        private void btnNumSieteNext_Click(object sender, EventArgs e)
        {
            Numero8 numeroOcho = new Numero8();
            numeroOcho.ShowDialog();
            this.Close
        }
    }
}
