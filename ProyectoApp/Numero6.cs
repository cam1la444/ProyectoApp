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
    public partial class Numero6 : Form
    {
        public Numero6()
        {
            InitializeComponent();
        }

        private void btnNumSeisClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNumSeisBack_Click(object sender, EventArgs e)
        {
            Numero5 numeroCinco = new Numero5();
            numeroCinco.ShowDialog();
            this.Close();
        }

        private void btnNumSeisNext_Click(object sender, EventArgs e)
        {
            Numero7 numeroSiete = new Numero7();
            numeroSiete.ShowDialog();
            this.Close();
        }
    }
}
