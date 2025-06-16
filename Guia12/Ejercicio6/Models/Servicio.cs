using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6.Models
{
    internal class Servicio
    {
        int[] valores = new int[10];
        int cantidad = 0;

        public void RegistrarValor(int valor)
        {
            valores[cantidad] = Convert.ToInt32(valor);
            cantidad++;
        }

        public int VerValor(int idx)
        {
            return valores[idx];
        }

        public int VerCantidad()
        {
            return cantidad;
        }

        public int Buscar(int valor, int tipoBusqueda)
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

        public void OrdenarValores(int tipoOrdenamiento)
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
            if (cantidad > 0)
                return suma / cantidad;
            return 0;
        }

        public int[] ListarSuperioresAlPromedio(out int cantSup)
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
    }
}
