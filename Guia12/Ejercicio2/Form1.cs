namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Form2 fDialogo = new Form2();

            fDialogo.lbMostrarValor.Text = tbValor.Text;

            fDialogo.ShowDialog();
        }
    }
}
