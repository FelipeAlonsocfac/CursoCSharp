using System;

namespace EjerciciosSeccion11
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                SwitchMenu();
            }
        }
        public static string Menu()
        {
            Console.WriteLine("*****Menu*****");
            Console.WriteLine("*****1. Ejercicio 1*****");
            Console.WriteLine("*****2. Ejercicio 2*****");
            Console.WriteLine("*****3. Ejercicio 3*****");
            Console.WriteLine("*****4. Salir*****");
            return Console.ReadLine();
        }
        public static void SwitchMenu()
        {
            switch (Menu())
            {
                case "1":
                    Ejercicios.Ej1();
                    break;
                case "2":
                    Ejercicios.Ej2();
                    break;
                case "3":
                    Ejercicios.Ej3();
                    break;
                case "4":
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
        }
    }
    class Ejercicios
    {
        public static void Ej1()
        {
            Diccionario dictionary = new Diccionario();
            dictionary.iteracion();
            dictionary.busqueda();
        }
        public static void Ej2()
        {
            ClaseGenerica<int> claseGen1 = new ClaseGenerica<int>();
            claseGen1.Add(123);
            claseGen1.Add(223);
            claseGen1.Add(332);

            ClaseGenerica<string> claseGen2 = new ClaseGenerica<string>();
            claseGen2.Add("A");
            claseGen2.Add("ef");
            claseGen2.Add("asf");
        }
        public static void Ej3()
        {
            Animal animal = new Animal();

            Console.WriteLine("Introduce un codigo de animal:");
            int codigo = int.Parse(Console.ReadLine());


            Console.WriteLine($"El codigo pertenece al {EsTipoAnimal(codigo)}");
        }
        public enum Animales
        {
            Canario = 2,
            Perro = 5,
            Gato = 8,
            Caballo = 12
        }
        public static string EsTipoAnimal(int tipoAnimal) => tipoAnimal switch
        {
            2 => Animales.Canario.ToString(),
            5 => Animales.Perro.ToString(),
            8 => Animales.Gato.ToString(),
            12 => Animales.Caballo.ToString(),
            _ => "Desconocido",
        };
    }      
}
