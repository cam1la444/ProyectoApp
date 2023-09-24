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
    public partial class Numero3 : Form
    {
        public Numero3()
        {
            InitializeComponent();
        }

        private void btnNumTresClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNumTresBack_Click(object sender, EventArgs e)
        {
            Numero2 numeroDos = new Numero2();
            numeroDos.ShowDialog();
            this.Close();
        }

        private void btnNumTresNext_Click(object sender, EventArgs e)
        {
            Numero4 numeroCuatro = new Numero4();
            numeroCuatro.ShowDialog();
            this.Close();
        }
    }
}
