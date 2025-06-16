using Ejercicio6.Models;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        Servicio servicio= new Servicio();

        public Form1()
        {
            InitializeComponent();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            #region elige el tipo de busqueda
            int tipoBusqueda = 0;
            if (rbSecuencial.Checked)
                tipoBusqueda = 1;
            else if (rbBiseccional.Checked)
                tipoBusqueda = 2;

            if (tipoBusqueda == 0)
            {
                MessageBox.Show("Debe seleccionar un tipo de búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            int valorABucar = Convert.ToInt32(tbValor.Text);

            int idx = servicio.Buscar(valorABucar, tipoBusqueda);

            lsbListado.Items.Clear();
            if (idx > -1)
                lsbListado.Items.Add($"Valor encontrado en la posición {idx}");
            else
                lsbListado.Items.Add($"valor no encontrado");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            int n = 0; 
            Form2 fDialogo = new Form2();

            while (n < 10 && fDialogo.ShowDialog() == DialogResult.OK)
            {
                int valor = Convert.ToInt32(fDialogo.tbValor.Text);
                
                servicio.RegistrarValor(valor);

                fDialogo.tbValor.Clear();
            }

            lbCantidad.Text = $"{servicio.VerCantidad()}";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lbCantidad.Text = "";

            #region tipo de ordeanmiento
            int tipo = 0;
            if (rbBurbuja.Checked == true)
                tipo = 1;
            else if (rbQuickSort.Checked == true)
                tipo = 2;

            if (tipo == 0)
            {
                MessageBox.Show("Debe seleccionar un tipo de ordenamiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            servicio.OrdenarValores(tipo);

            lsbListado.Items.Clear();
            for (int n = 0; n < servicio.VerCantidad(); n++)
            {
                lsbListado.Items.Add($"Valor {n}: {servicio.VerValor(n)}");
            }

            lbCantidad.Text = $"{servicio.VerCantidad()}";
        }

        private void btnSuperanAlPromedio_Click(object sender, EventArgs e)
        {
            lbCantidad.Text = "";

            int cantidadSuperior = 0;
            int[] idxs = servicio.ListarSuperioresAlPromedio(out cantidadSuperior);

            lsbListado.Items.Clear();
            for (int n = 0; n < cantidadSuperior; n++)
            {
                int idx = idxs[n];
                lsbListado.Items.Add($"Valor {n}: {servicio.VerValor(idx)}");
            }

            lbCantidad.Text = $"{cantidadSuperior}";
        }
    }
}
