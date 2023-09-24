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
    public partial class Número0 : Form
    {
        public Número0()
        {
            InitializeComponent();
        }

        private void btnCeroClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCeroSiguiente_Click(object sender, EventArgs e)
        {
            Numero1 numeroUno = new Numero1();
            numeroUno.ShowDialog();
            this.Close();
        }
    }
}
