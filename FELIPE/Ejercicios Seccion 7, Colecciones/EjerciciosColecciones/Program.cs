using System;
using System.Collections;
using System.Collections.Generic;

namespace EjerciciosColecciones
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
            Console.WriteLine("*****4. Ejercicio 4*****");
            Console.WriteLine("*****5. Ejercicio 5*****");
            Console.WriteLine("*****6. Ejercicio 6*****");
            Console.WriteLine("*****7. Salir*****");
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
                    Ejercicios.Ej4();
                    break;
                case "5":
                    Ejercicios.Ej5();
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
        }
    }

    class Ejercicios {
        public static void Ej1() {
            ArrayList arList = new ArrayList();
            int suma = 0;
            for (int i = 1; i < 1000; i++)
            {
                arList.Add(i);
            }
            foreach (int item in arList)
            {
                suma = suma + item;
                Console.WriteLine($"{suma}, ");
            }
        }
        public static void Ej2()
        {
            List<string> lista = new List<string>();
            string item;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un Nombre");
                lista.Add(Console.ReadLine().ToLower());
            }
            Console.WriteLine("Ahora ingrese un nombre para saber si esta en la lista");
            if ( lista.Contains(Console.ReadLine().ToLower()))
            {
                Console.WriteLine("El nombre esta en la lista");
            }
            else Console.WriteLine("El nombre no esta en la lista");

        }
        public static void Ej3()
        {
            Console.WriteLine("Escribe 10 numeros para sumar pares y restar impares");
            var pares = new List<int>();
            var impares = new List<int>();
            int numero = 0;
            int sumaPares = 0, sumaImpares = 0;
            for (int i = 0; i < 10; i++)
            {
                if ((numero = int.Parse(Console.ReadLine())) % 2 == 0)
                {
                    pares.Add(numero);
                }
                else impares.Add(numero);
            }
            foreach (var item in pares)
            {
                sumaPares += item;
            }
            foreach (var item in impares)
            {
                sumaImpares -= item;
            }
            Console.WriteLine($"Los pares suman: {sumaPares} y los impares restan: {sumaImpares}");
        }
        public static void Ej4()
        {
            Queue cola = new Queue();
            Console.WriteLine("Introduce 10 numeros");
            int mayor = int.MinValue, menor = int.MaxValue;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Numero {i+1}: ");
                cola.Enqueue(int.Parse(Console.ReadLine()));
            }
            foreach (int item in cola)
            {
                if (item > mayor) mayor = item;
                if (item < menor) menor = item;
            }
            Console.WriteLine($"El valor mayor de la cola es: {mayor} y el mas pequeño es: {menor}");
        }
        public static void Ej5()
        {
            var arrList = new ArrayList();
            Console.WriteLine("Cuantos elementos quieres insertar en el array?");
            int nElementos = int.Parse(Console.ReadLine());
            int elementoReemplazo;
            int posicion;

            for (int i = 0; i < nElementos; i++)
            {
                Console.WriteLine($"Elemento {i}: ");
                arrList.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Ahora dame un nuevo elemento");
            elementoReemplazo = int.Parse(Console.ReadLine());
            Console.WriteLine("Y dame tambien la posicion en la que insertar dicho elemento");
            posicion = int.Parse(Console.ReadLine());
            arrList.Insert(posicion -1, elementoReemplazo);
        }
    }
}
