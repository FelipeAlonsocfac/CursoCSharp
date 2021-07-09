using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosCadenas
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

            Console.WriteLine("\nIngresa tu nombre");
            string nombre = Console.ReadLine().ToString();
            string nombreLower = nombre.ToLower();
            if (nombreLower.Contains("alejandro")) {
                Console.WriteLine($"\nHola {nombre}.\n");
            }
            else Console.WriteLine("No te conozco\n");
        }
        public static void Ej2() {
            Console.WriteLine("Dame la palabra a invertir");
            string palabra = Console.ReadLine().ToString();
            var palabraCaracter = palabra.ToCharArray();
            string palabraInvertida = "";
            for (int i = palabra.Length-1; i >= 0; i--)
            {
                palabraInvertida += palabraCaracter[i].ToString();
            }
            palabraInvertida = palabraInvertida.ToLower();
            Console.WriteLine(palabraInvertida);
        }
        public static void Ej3()
        {
            Console.WriteLine("Dame una frase de al menos 20 caracteres y 4 palabras");
            string frase = Console.ReadLine().ToString();
            char[] separators = new char[] { ' ', '.' ,','};
            var subs = frase.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string fraseFinal;
            
            if (!(frase.Length > 20 && subs.Length >4)) {
                Console.WriteLine("La frase no cumple los requisitos");
                return;
            }
            Console.WriteLine($"La longitud de la cadena es {frase.Length}");
            string fraseReemplazada = frase.Replace('a','x');
            fraseReemplazada = fraseReemplazada.Replace('A', 'X');
            Console.WriteLine($"Reemplazando las x con las a: {fraseReemplazada}");
            Console.WriteLine($"La cadena en mayusculas es: {frase.ToUpper()}");
            Console.WriteLine($"La cadena en minusculas es: {frase.ToLower()}");
            Console.WriteLine($"La cadena sin las 3 primeras letras es: {frase.Remove(0,3)}");
            Console.WriteLine($"Las letras de la posicion 5 a la 10 son: {frase.Substring(5,5)}");
            Console.WriteLine($"La frase tiene {subs.Length} palabras");
            Console.WriteLine($"La tercera palabra es: {subs[2]}");
        }
        public static void Ej4()
        {
            StringBuilder sb = new StringBuilder();

            var listaCadenas = new List<int>();
            Console.WriteLine("Introduce cuatro numeros");
            listaCadenas.Add(int.Parse(Console.ReadLine()));
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("introduce otro numero");
                listaCadenas.Add(int.Parse(Console.ReadLine()));
            }

            sb.Append($"El primer numero introducido es el {listaCadenas[0]}, ");
            sb.Append($"despues han introducido el {listaCadenas[1]} "); 
            sb.Append($"y { listaCadenas[2]} ");
            sb.Append($"y por ultimo el {listaCadenas[3]}");

            Console.WriteLine(sb.ToString());
        }
        public static void Ej5()
        {
            Console.WriteLine("Abecedario descendiente en mayusculas:");
            for (int i = 90; i >= 65; i--)
            {
                Console.Write($"{(char)i}, ");
            }
            Console.WriteLine("\n");
        }
    }
}
