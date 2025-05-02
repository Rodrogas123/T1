using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    internal class Gato
    {
        public string Nombre { get; private set; }
        public int Edad { get; private set; }
        public double PrecioCompra { get; private set; }

        public Gato(string nombre, int edad, double precioCompra)
        {
            Nombre = nombre;
            Edad = edad;
            PrecioCompra = precioCompra;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Edad: {Edad}, Precio: {PrecioCompra}";
        }
    }
}
