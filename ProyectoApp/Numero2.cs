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
    public partial class Numero2 : Form
    {
        public Numero2()
        {
            InitializeComponent();
        }

        private void btnDosBack_Click(object sender, EventArgs e)
        {
            Numero1 numeroUno = new Numero1();
            numeroUno.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
