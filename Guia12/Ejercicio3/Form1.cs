namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            Form2 fDialogo = new Form2();

            int n = 0;
            while (n<10 && fDialogo.ShowDialog() == DialogResult.OK)
            {
                string valor= fDialogo.tbValor.Text;
                lsbListado.Items.Add(valor);
                n++;

                fDialogo.tbValor.Clear();
            }

            lbCantidad.Text = $"{n}";
        }
    }
}
