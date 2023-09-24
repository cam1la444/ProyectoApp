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
    public partial class Numero10 : Form
    {
        public Numero10()
        {
            InitializeComponent();
        }

        private void btnNumDiezClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNumDiezBack_Click(object sender, EventArgs e)
        {
            Numero9 numeroNueve = new Numero9();
            numeroNueve.ShowDialog();
            this.Close();
        }

        private void btnNumDiezNext_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
