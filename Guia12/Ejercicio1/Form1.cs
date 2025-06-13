namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            Form2 fDialogo=new Form2();

            if (fDialogo.ShowDialog() == DialogResult.OK)
            {
                lbMostrarValor.Text = fDialogo.tbValor.Text;
            }
            else
            {
                lbMostrarValor.Text = "Cancelo la Solicitud del valor";
            }

        }
    }
}
