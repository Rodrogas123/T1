using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazadaS listaGatos = new ListaEnlazadaS();
            int opcion;

            do
            {
                Console.Clear(); 
                Console.WriteLine("Menú:");
                Console.WriteLine("1) Agregar");
                Console.WriteLine("2) Listar");
                Console.WriteLine("3) Eliminar");
                Console.WriteLine("4) Mostrar segunda mitad");
                Console.WriteLine("5) Precio Medio");
                Console.WriteLine("6) Fin");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                Console.Clear(); 

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre del gato: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Edad del gato: ");
                        int edad = int.Parse(Console.ReadLine());
                        Console.Write("Precio de compra del gato: ");
                        double precio = double.Parse(Console.ReadLine());
                        listaGatos.Agrega2daPos(nombre, edad, precio);
                        Console.WriteLine("Gato agregado correctamente.");
                        break;

                    case 2:
                        Console.WriteLine("Lista de Gatos:");
                        listaGatos.Listar();
                        break;

                    case 3:
                        listaGatos.QuitaUltimo();
                        Console.WriteLine("Último gato eliminado.");
                        break;

                    case 4:
                        Console.WriteLine("Segunda mitad de la lista:");
                        ListaEnlazadaS segundaMitad = listaGatos.SegundaMitad();
                        segundaMitad.Listar();
                        break;

                    case 5:
                        Console.WriteLine($"Precio medio: {listaGatos.PrecioMedio()}");
                        break;

                    case 6:
                        Console.WriteLine("Fin del programa.");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (opcion != 6)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey(); 
                }

            } while (opcion != 6);
        }
    }
}
