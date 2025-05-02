using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    internal class ListaEnlazadaS
    {
        private NodoS Primero;

        public void Agrega2daPos(string nombre, int edad, double precioCompra)
        {
            Gato nuevoGato = new Gato(nombre, edad, precioCompra);
            NodoS nuevoNodo = new NodoS(nuevoGato);

            if (Primero == null)
            {
                Primero = nuevoNodo;
            }
            else if (Primero.Sig == null)
            {
                nuevoNodo.Sig = Primero.Sig;
                Primero.Sig = nuevoNodo;
            }
            else
            {
                nuevoNodo.Sig = Primero.Sig;
                Primero.Sig = nuevoNodo;
            }
        }

        public void QuitaUltimo()
        {
            if (Primero == null) return;

            if (Primero.Sig == null)
            {
                Primero = null;
                return;
            }

            NodoS actual = Primero;
            while (actual.Sig.Sig != null)
            {
                actual = actual.Sig;
            }
            actual.Sig = null;
        }

        public int Cantidad()
        {
            int contador = 0;
            NodoS actual = Primero;
            while (actual != null)
            {
                contador++;
                actual = actual.Sig;
            }
            return contador;
        }

        public Gato GetGato(int posicion)
        {
            if (posicion < 0) return null;

            NodoS actual = Primero;
            int indice = 0;

            while (actual != null)
            {
                if (indice == posicion)
                {
                    return actual.Dato;
                }
                actual = actual.Sig;
                indice++;
            }
            return null;
        }

        public double PrecioMedio()
        {
            if (Primero == null) return 0;

            double precioMayor = double.MinValue;
            double precioMenor = double.MaxValue;

            NodoS actual = Primero;
            while (actual != null)
            {
                if (actual.Dato.PrecioCompra > precioMayor)
                    precioMayor = actual.Dato.PrecioCompra;

                if (actual.Dato.PrecioCompra < precioMenor)
                    precioMenor = actual.Dato.PrecioCompra;

                actual = actual.Sig;
            }

            return (precioMayor + precioMenor) / 2;
        }

        public ListaEnlazadaS SegundaMitad()
        {
            ListaEnlazadaS nuevaLista = new ListaEnlazadaS();
            int total = Cantidad();
            int mitad = total / 2;

            NodoS actual = Primero;
            int indice = 0;

            while (actual != null)
            {
                if (indice >= mitad)
                {
                    nuevaLista.Agrega2daPos(actual.Dato.Nombre, actual.Dato.Edad, actual.Dato.PrecioCompra);
                }
                actual = actual.Sig;
                indice++;
            }

            return nuevaLista;
        }

        public void Listar()
        {
            NodoS actual = Primero;
            while (actual != null)
            {
                Console.WriteLine(actual.Dato);
                actual = actual.Sig;
            }
        }
    }
}
