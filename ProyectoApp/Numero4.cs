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
    public partial class Numero4 : Form
    {
        public Numero4()
        {
            InitializeComponent();
        }

        private void btnNumCuatroClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNumCuatroBack_Click(object sender, EventArgs e)
        {
            Numero3 numeroTres = new Numero3();
            numeroTres.ShowDialog();
            this.Close();
        }

        private void btnNumCuatroNext_Click(object sender, EventArgs e)
        {
            Numero5 numeroCinco = new Numero5();
            numeroCinco.ShowDialog();
            this.Close();
        }
    }
}
