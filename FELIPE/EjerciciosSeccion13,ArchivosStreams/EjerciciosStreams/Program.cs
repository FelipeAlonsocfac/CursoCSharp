using System;
using System.Collections.Generic;
using System.IO;
namespace EjerciciosStreams
{
    class Program
    {
        private static List<Persona> personasArchivo = new List<Persona>();
        private static ManejoFilestreams fsPersonas = new ManejoFilestreams();
        private static Persona personaActual = new Persona();
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
            Console.WriteLine("*****1. Nueva persona*****");
            Console.WriteLine("*****2. Ver personas*****");
            Console.WriteLine("*****3. Salir*****");
            return Console.ReadLine();
        }
        public static void SwitchMenu()
        {
            switch (Menu())
            {
                case "1":
                    personaActual = fsPersonas.Add();
                    break;
                case "2":
                    personasArchivo = fsPersonas.Get();
                    foreach (var item in personasArchivo)
                    {
                        Console.WriteLine($"Nombre: {item.nombre}. Edad: {item.edad}. Localidad: {item.localidad}");
                    }
                    break;
                case "3":
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
        }
    }
}
