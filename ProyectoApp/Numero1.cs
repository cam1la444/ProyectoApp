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
    public partial class Numero1 : Form
    {
        public Numero1()
        {
            InitializeComponent();
        }

        private void btnUnoCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUnoBack_Click(object sender, EventArgs e)
        {
            Número0 numeroCero = new Número0();
            numeroCero.ShowDialog();
            this.Close();
        }

        private void btnUnoNext_Click(object sender, EventArgs e)
        {
            Numero2 numeroDos = new Numero2();
            this.Close();
        }
    }
}
