using System;
using System.Collections.Generic;

namespace EjerciciosIntroduccionCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicios.Ej1();
            Ejercicios.Ej2();
            Ejercicios.Ej3();
            Ejercicios.Ej4();
            Ejercicios.Ej5();
            Ejercicios.Ej6();
            Ejercicios.Ej7();
            Ejercicios.Ej8();
            Ejercicios.Ej9();
            Ejercicios.Ej10();
            Ejercicios.Ej11();
            Ejercicios.Ej12();
            Ejercicios.Ej13();
            Ejercicios.Ej14();
        }
    }
    public class Ejercicios
    {
        public static void Ej1() {
            int num1 = 3, num2 = 2, num3 = 2, result;

            Console.WriteLine(result = num1 + num2 + num3);
        }
        public static void Ej2() {
            int num1, num2;

            Console.WriteLine("Dame el valor del primer numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dame el valor del segundo numero");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2) Console.WriteLine($"El {num1} es mayor que el {num2}");
            else if (num2 > num1) Console.WriteLine($"El {num2} es mayor que el {num1}");
            else Console.WriteLine($"El {num1} y el {num2} son iguales");
        }
        public static void Ej3() {
            string dia;

            Console.WriteLine("Dame el dia de la semana y te dire si es fin de semana o no");
            dia = Console.ReadLine();
            dia = dia.ToLower();

            switch (dia)
            {
                case "lunes":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "martes":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "miercoles":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "jueves":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "viernes":
                    Console.WriteLine("Si es fin de semana");
                    break;
                case "sabado":
                    Console.WriteLine("Si es fin de semana");
                    break;
                case "domingo":
                    Console.WriteLine("Si es fin de semana");
                    break;
                default:
                    Console.WriteLine("Lo siento, eso no corresponde a un dia de la semana");
                    break;
            }
        }
        public static void Ej4() {

            Console.Write("Valor del producto?: ");
            uint precio = uint.Parse(Console.ReadLine());

            Console.WriteLine("Que medio de pago desea usar?\n 1.efectivo\n 2.tarjeta");
            int tipoPago = int.Parse(Console.ReadLine());


            switch (tipoPago)
            {
                case 1:
                    Console.WriteLine("Gracias por su compra");
                    break;
                case 2:
                    Console.WriteLine("Inserte numero de cuenta");
                    Console.ReadLine();
                    Console.WriteLine("Gracias por su compra");
                    break;
                default:
                    Console.WriteLine("Tipo de pago no valido.");
                    break;
            }
        }
        public static void Ej5() {

            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");
        }
        public static void Ej6() {
            int i = 0;

            while (i <= 100) {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("");
        }
        public static void Ej7() {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0) Console.WriteLine(i);
            }
            Console.WriteLine("");
        }
        public static void Ej8() {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0 || i % 3 == 0) Console.WriteLine(i);
            }
            Console.WriteLine("");
        }
        public static void Ej9() {
            List<int> numPares = new List<int>();
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0) numPares.Add(i);
            }
            foreach (var item in numPares)
            {
                Console.WriteLine(item);
            }
        }
        public static void Ej10() {

            var numeros = new List<int>();
            Console.WriteLine("Dame el valor del primer numero");
            numeros.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dame el valor del segundo numero");
            numeros.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dame el valor del tercer numero");
            numeros.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dame el valor del cuarto numero");
            numeros.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dame el valor del quinto numero");
            numeros.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dame el valor del sexto numero");
            numeros.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dame el valor del septimo numero");
            numeros.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dame el valor del octavo numero");
            numeros.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dame el valor del noveno numero");
            numeros.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dame el valor del decimo numero");
            numeros.Add(int.Parse(Console.ReadLine()));

            int suma = 0, resta = 0;

            foreach (var recorrido in numeros)
            {
                if (recorrido % 2 == 0)
                {
                    suma = suma + recorrido;
                }
                else {
                    resta = resta - recorrido;
                }
            }

            Console.WriteLine($"Los pares suman: {suma} y los impares restan: {resta}");
        }
        public static void Ej11() {
            int dia;

            Console.WriteLine("De un numero del 1 al 7");
            dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Numero ingresado incorrecto");
                    break;
            }
        }
        public static void Ej12() {

            int suma = 0, media;

            Console.WriteLine("Introduzca un numero del 1 al 1000");
            int numero = int.Parse(Console.ReadLine());

            if (!(numero >= 1 && numero <= 1000)) {
                Console.WriteLine("Numero introducido incorrecto");
                return;
            }
            for (int i = 0; i < numero; i++)
            {
                suma = suma + i;
            }
            media = suma / numero;
            Console.WriteLine($"La suma es {suma} y la media es {media}");
        }
        public static void Ej13() {
            int nDivisores = 0;
            Console.WriteLine("Ingrese numero para comprobar si es primo");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0) nDivisores += 1;
            }
            if (nDivisores == 2) {
                Console.WriteLine("Numero primo");
            }
            else Console.WriteLine("Numero no primo");
        }
        public static void Ej14() {

            Console.WriteLine("Ingrese numero para saber cuantas cifras tiene");
            uint numero = uint.Parse(Console.ReadLine());
            int nCifras = 1;

            while (true) {
                numero /= 10;
                if (numero != 0) nCifras++;
                else break;
            }
            Console.WriteLine($"El numero tiene {nCifras} cifras");
        }
    }
}
