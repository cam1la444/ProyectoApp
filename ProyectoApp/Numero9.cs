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
    public partial class Numero9 : Form
    {
        public Numero9()
        {
            InitializeComponent();
        }

        private void btnNumNueveClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNumNueveBack_Click(object sender, EventArgs e)
        {
            Numero8 numeroOcho = new Numero8();
            numeroOcho.ShowDialog();
            this.Close();
        }

        private void btnNumNueveNext_Click(object sender, EventArgs e)
        {
            Numero10 numeroDiez = new Numero10();
            numeroDiez.ShowDialog();
            this.Close();
        }
    }
}
