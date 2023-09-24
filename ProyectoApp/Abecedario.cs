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
            LetraA letraa = new LetraA();
            letraa.ShowDialog();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            LetraB letrab = new LetraB();
            letrab.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            LetraC letrac = new LetraC();
            letrac.ShowDialog();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            LetraE letrae = new LetraE();
            letrae.ShowDialog();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            LetraD letrad = new LetraD();
            letrad.ShowDialog();
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            LetraF letraf = new LetraF();
            letraf.ShowDialog();
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            LetraG letrag = new LetraG();
            letrag.ShowDialog();
        }
    }
}