using System;
using System.Globalization;
using System.Collections.Generic;

namespace EjerciciosMetodosFunciones
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                SwitchMenu();
            }
        }
        public static string Menu() {
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
        public static void SwitchMenu() {
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
                case "6":
                    Ejercicios.Ej6();
                    break;
                case "7":
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
        }
    }
    class Ejercicios {
        public static void Ej1() {
            Console.WriteLine("Dame la tasa de cambio de dolar a euro");
            double tasa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Cuantos dolares quieres cambiar?");
            double nDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"{nDolares} equivale a {tasa*nDolares} euros");
        }
        public static void Ej2()
        {
            float num1, num2;
            switch (MenuCalculadora())
            {
                case "1":
                    Console.WriteLine("Dame el primer numero");
                    num1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Dame el segundo numero");
                    num2 = float.Parse(Console.ReadLine());
                    Console.WriteLine($"La suma entre {num1} y {num2} es {num1 + num2}");
                    break;
                case "2":
                    Console.WriteLine("Dame el primer numero");
                    num1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Dame el segundo numero");
                    num2 = float.Parse(Console.ReadLine());
                    Console.WriteLine($"La resta entre {num1} y {num2} es {num1 - num2}");
                    break;
                case "3":
                    Console.WriteLine("Dame el primer numero");
                    num1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Dame el segundo numero");
                    num2 = float.Parse(Console.ReadLine());
                    Console.WriteLine($"La multiplicacion entre {num1} y {num2} es {num1 * num2}");
                    break;
                case "4":
                    Console.WriteLine("Dame el primer numero");
                    num1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Dame el segundo numero");
                    num2 = float.Parse(Console.ReadLine());
                    Console.WriteLine($"La division entre {num1} y {num2} es {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;
            }
        }
        public static void Ej3()
        {
            Console.WriteLine("Ingrese importe:");
            decimal importe = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            NumeroBilletesMonedas(importe);
            Console.WriteLine($"Para un cambio de {importe}\n");
        }
        public static void Ej4()
        {
            Console.WriteLine("Hola");
        }
        public static void Ej5()
        {

        }
        public static void Ej6()
        {

        }
        public static string MenuCalculadora() {
            Console.WriteLine("*****Menu Calculadora*****");
            Console.WriteLine("*****1. Suma*****");
            Console.WriteLine("*****2. Resta*****");
            Console.WriteLine("*****3. Multiplicacion*****");
            Console.WriteLine("*****4. Division*****");
            return Console.ReadLine();
        }
        public static void NumeroBilletesMonedas(decimal importe) {
            int[] array = new int[15];   //asi se inicializa una matriz
            while (importe > 0) {
                if (importe - 500 >= 0) {
                    array[0]++;
                    importe -= 500;
                }
                else if (importe - 200 >= 0) {
                    array[1]++;
                    importe -= 200;
                }
                else if (importe - 100 >= 0)
                {
                    array[2]++;
                    importe -= 100;
                }
                else if (importe - 50 >= 0)
                {
                    array[3]++;
                    importe -= 50;
                }
                else if (importe - 20 >= 0)
                {
                    array[4]++;
                    importe -= 20;
                }
                else if (importe - 10 >= 0)
                {
                    array[5]++;
                    importe -= 10;
                }
                else if (importe - 5 >= 0)
                {
                    array[6]++;
                    importe -= 5;
                }
                else if (importe - 2 >= 0)
                {
                    array[7]++;
                    importe -= 2;
                }
                else if (importe - 1 >= 0)
                {
                    array[8]++;
                    importe -= 1;
                }
                else if (Decimal.Subtract(importe, 0.5m) >= 0)
                {
                    array[9]++;
                    importe = Decimal.Subtract(importe, 0.5m);
                }
                else if (Decimal.Subtract(importe, 0.2m) >= 0)
                {
                    array[10]++;
                    importe = Decimal.Subtract(importe, 0.2m);
                }
                else if (Decimal.Subtract(importe, 0.1m) >= 0)
                {
                    array[11]++;
                    Decimal.Subtract(importe, 0.1m);
                }
                else if (Decimal.Subtract(importe, 0.05m) >= 0)
                {
                    array[12]++;
                    Decimal.Subtract(importe, 0.05m);
                }
                else if (Decimal.Subtract(importe, 0.02m) >= 0)
                {
                    array[13]++;
                    importe = Decimal.Subtract(importe, 0.02m);
                }
                else if (Decimal.Subtract(importe, 0.01m) >= 0)
                {
                    array[14]++;
                    importe = Decimal.Subtract(importe, 0.01m);
                }
            }
            Console.Write("\nSe necesitan: ");
            if (array[0] != 0) Console.Write($"{array[0]} billetes de 500. ");
            if (array[1] != 0) Console.Write($"{array[1]} billetes de 200. ");
            if (array[2] != 0) Console.Write($"{array[2]} billetes de 100. ");
            if (array[3] != 0) Console.Write($"{array[3]} billetes de 50. ");
            if (array[4] != 0) Console.Write($"{array[4]} billetes de 20. ");
            if (array[5] != 0) Console.Write($"{array[5]} billetes de 10. ");
            if (array[6] != 0) Console.Write($"{array[6]} billetes de 5. ");
            if (array[7] != 0) Console.Write($"{array[7]} monedas de 2. ");
            if (array[8] != 0) Console.Write($"{array[8]} monedas de 1. ");
            if (array[9] != 0) Console.Write($"{array[9]} monedas de 50 centimos. ");
            if (array[10] != 0) Console.Write($"{array[10]} monedas de 20 centimos. ");
            if (array[11] != 0) Console.Write($"{array[11]} monedas de 10 centimos. ");
            if (array[12] != 0) Console.Write($"{array[12]} monedas de 5 centimos. ");
            if (array[13] != 0) Console.Write($"{array[13]} monedas de 2 centimos. ");
            if (array[14] != 0) Console.WriteLine($"y {array[14]} monedas de 1 centimo.");
        }
    }
}
