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
    public partial class Numero5 : Form
    {
        public Numero5()
        {
            InitializeComponent();
        }

        private void btnNumCincoClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNumCincoBack_Click(object sender, EventArgs e)
        {
            Numero4 numeroCuatro = new Numero4();
            numeroCuatro.ShowDialog();
            this.Close();
        }

        private void btnNumCincoNext_Click(object sender, EventArgs e)
        {
            Numero6 numeroSeis = new Numero6();
            numeroSeis.ShowDialog();
            this.Close();
        }
    }
}
