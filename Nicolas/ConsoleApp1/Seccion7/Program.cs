using System;
using System.Collections.Generic;

namespace Seccion7
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
            List<int> lista = new List<int>();

            for (int i = 1; i <= 1000; i++)
            {
                lista.Add(i);
            }
            int suma = 0;
            foreach (var item in lista)
            {
                suma += item;
                Console.WriteLine(suma);
            }
        }
        public static void Punto2() 
        {
            
        }
        public static void Punto3() { }
        public static void Punto4() { }
        public static void Punto5() { }

    }
}
