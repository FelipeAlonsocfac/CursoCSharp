﻿using System;

namespace Seccion6
{
    class Program
    {
        static void Main(string[] args)
        {

            int numeroMenu = Menu();
            while (numeroMenu >= 1 && numeroMenu <= 5)
            {
                SelectorMenu(ref numeroMenu);
                numeroMenu = Menu();
            }
        }

        public static int Menu()
        {
            Console.WriteLine("Ingrese el punto deseado (1-5)");
            return int.Parse(Console.ReadLine());
        }
        public static void SelectorMenu(ref int numeroMenu)
        {
            switch (numeroMenu)
            {
                case 1:
                    Punto1();
                    break;

                case 2:
                    Punto2();
                    break;

                case 3:
                    Punto3();
                    break;

                case 4:
                    Punto4();
                    break;

                case 5:
                    Punto5();
                    break;

               default:
                    break;
            }
        }
        public static void Punto1() 
        {
            Console.WriteLine("Escribe tu nombre: ");
            String nombre = Console.ReadLine();

            if (String.Equals(nombre, "alejandro", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Hola");
            }
            else
            {
                Console.WriteLine("No te conozco");
            }
        }
        public static void Punto2() 
        {
            Console.WriteLine("Escribe una palabra");
            char[] palabra = Console.ReadLine().ToCharArray();
            Array.Reverse(palabra);
            Console.WriteLine(palabra);

        }
        public static void Punto3() { }
        public static void Punto4() { }
        public static void Punto5() { }
    }
}
