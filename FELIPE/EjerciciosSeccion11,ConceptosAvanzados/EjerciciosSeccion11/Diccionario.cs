using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSeccion11
{
    class Diccionario
    {

        private Dictionary<int, string> diccionario = new Dictionary<int,string>();


        public void iteracion() {
            int clave;
            string valor;
            //se iterara pidiendo int y string como clave y valor, hasta que la clave insertada sea 0
            Console.WriteLine($"Ingrese una clave y una cadena por entrada. Para terminar pulse 0");
            while (true) {
                Console.WriteLine("Ingrese clave");
                clave = int.Parse(Console.ReadLine());
                if (clave == 0) break;
                Console.WriteLine("Ingrese valor");
                valor = Console.ReadLine();
                if (valor == "0") break;
                diccionario.Add(clave, valor);
            }
        }
        public void busqueda() {
            string valorABuscar;
            Console.WriteLine("Ingrese valor a buscar (max 2 letras)");
            valorABuscar = Console.ReadLine();
            if (valorABuscar.Length > 2) {
                Console.WriteLine("Error, cadena mayor a dos letras");
                return;
            }
            if (!diccionario.ContainsValue(valorABuscar))
            {
                Console.WriteLine("No hay coincidencias");
                return;
            }
            Console.WriteLine("las claves que contienen dicho valor son: ");
            Console.WriteLine("\n  clave|valor\n");
            foreach (var item in diccionario)
            {
                if (item.Value.Contains(valorABuscar)){
                    Console.WriteLine($"\t{item.Key}, {item.Value}");
                }
            }
        }
    }
}
