using System.Drawing;
using System.Net.NetworkInformation;
using System.Security.Permissions;
using System.Transactions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        int[] valores = new int[10];
        int cantidad = 0;

        void RegistrarValor(int valor)
        {
            valores[cantidad] = Convert.ToInt32(valor);
            cantidad++;
        }

        int VerValor(int idx)
        {
            return valores[idx];
        }

        int Buscar(int valor, int tipoBusqueda)
        {
            if (tipoBusqueda == 1)
                return BusquedaSecuencial(valor);
            else
            {
                OrdenarValores(1);
                return BusquedaBinaria(valor);
            }
            return 0;
        }

        int BusquedaSecuencial(int valor)
        {
            int idx = -1;
            int n = 0;
            while (idx == -1 && n < cantidad)
            {
                if (valores[n] == valor)
                    idx = n;
                n++;
            }
            return idx;
        }

        int BusquedaBinaria(int valor)
        {
            int inicio = 0;
            int fin = cantidad - 1;
            int idx = -1;
            while (inicio <= fin && idx == -1)
            {
                int medio = (inicio + fin) / 2;
                if (valores[medio] == valor)
                    idx = medio;
                else if (valores[medio] < valor)
                    inicio = medio + 1;
                else
                    fin = medio - 1;
            }
            return idx;
        }

        void OrdenarValores(int tipoOrdenamiento)
        {
            if (tipoOrdenamiento == 1)
            {
                OrdenamientoBurbuja();
            }
            else
            {
                OrdenamientoQuicksort(0, cantidad - 1);
            }
        }

        double CalcularPromedio()
        {
            double suma = 0;
            for (int n = 0; n < cantidad; n++)
            {
                suma += valores[n];
            }
            if(cantidad>0)
                return suma / cantidad;
            return 0;
        }

        int[] ListarSuperioresAlPromedio(out int cantSup)
        {
            cantSup = 0;
            double promedio = CalcularPromedio();
            int[] idxs = new int[cantidad];
            for (int n = 0; n < cantidad; n++)
            {
                if (valores[n] > promedio)
                {
                    idxs[cantSup] = n;
                    cantSup++;
                }
            }
            return idxs;
        }
        void OrdenamientoBurbuja()
        {
            for (int n = 0; n < cantidad - 1; n++)
            {
                for (int m = n + 1; m < cantidad; m++)
                {
                    if (valores[n] > valores[m])
                    {
                        Intercambio(n, m);
                    }
                }
            }
        }
        void OrdenamientoQuicksort(int inicio, int fin)
        {
            int p = valores[inicio];
            int izq = inicio + 1;        //p | left .....  right |
            int der = fin;

            while (izq <= der)
            {
                while (izq <= fin && valores[izq] < p) izq++;
                while (der > inicio && valores[der] >= p) der--;
                if (izq < der) Intercambio(izq, der);
            }
            int pidx = der;
            Intercambio(inicio, pidx);

            if (pidx - 1 > inicio)
                OrdenamientoQuicksort(inicio, pidx - 1);
            if (pidx + 1 < fin)
                OrdenamientoQuicksort(pidx + 1, fin);
        }

        void Intercambio(int n, int m)
        {
            int aux = valores[n];
            valores[n] = valores[m];
            valores[m] = aux;
        }

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

            int idx = Buscar(valorABucar, tipoBusqueda);

            lsbListado.Items.Clear();
            if (idx > -1)
                lsbListado.Items.Add($"Valor encontrado en la posición {idx}");
            else
                lsbListado.Items.Add($"valor no encontrado");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            cantidad = 0;
            Form2 fDialogo = new Form2();

            while (cantidad < 10 && fDialogo.ShowDialog() == DialogResult.OK)
            {
                RegistrarValor(Convert.ToInt32(fDialogo.tbValor.Text));

                fDialogo.tbValor.Clear();
            }

            lbCantidad.Text = $"{cantidad}";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lbCantidad.Text = "";

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

            OrdenarValores(tipo);

            lsbListado.Items.Clear();
            for (int n = 0; n < cantidad; n++)
            {
                lsbListado.Items.Add($"Valor {n}: {VerValor(n)}");
            }

            lbCantidad.Text = $"{cantidad}";
        }

        private void btnSuperanAlPromedio_Click(object sender, EventArgs e)
        {
            lbCantidad.Text = "";

            int cantidadSuperior = 0;
            int[] idxs=ListarSuperioresAlPromedio(out cantidadSuperior);

            lsbListado.Items.Clear();
            for (int n = 0; n < cantidadSuperior; n++)
            {
                int idx = idxs[n];
                lsbListado.Items.Add($"Valor {n}: {VerValor(idx)}");
            }

            lbCantidad.Text = $"{cantidadSuperior}";
        }
    }
}
