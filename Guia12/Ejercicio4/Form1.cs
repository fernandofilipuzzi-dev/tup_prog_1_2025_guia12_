using System.Drawing;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            int[] valores=new int[10];
            int cantidad=0;

            Form2 fDialogo = new Form2();

            while (cantidad < 10 && fDialogo.ShowDialog() == DialogResult.OK)
            {
                valores[cantidad] = Convert.ToInt32( fDialogo.tbValor.Text );
                 
                cantidad++;

                fDialogo.tbValor.Clear();
            }

            lbCantidad.Text = $"{cantidad}";

            lsbListado.Items.Clear();
            
            if (cantidad == 10)
            {
                for (int n = 0; n < cantidad; n++)
                {
                    lsbListado.Items.Add(valores[n]);
                }
            }
            else
            {
                lsbListado.Items.Add("Se ha cancelado la carga.");
            }
             
        }
    }
}
