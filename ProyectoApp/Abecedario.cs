namespace ProyectoApp
{
    public partial class Abecedario : Form
    {
        public Abecedario()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, EventArgs e)
        {

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            LetraB letrab = new LetraB();
            letrab.ShowDialog();
        }
    }
}