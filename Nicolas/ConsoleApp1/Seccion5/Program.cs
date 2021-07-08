using System;

namespace Seccion5
{
    class Program
    {
        static void Main(string[] args)
        {

            int numeroMenu = Menu();
            while (numeroMenu >= 1 && numeroMenu <= 6)
            {
                SelectorMenu(ref numeroMenu);
                numeroMenu = Menu();
            }
        }

        public static int Menu()
        {
            Console.WriteLine("Ingrese el punto deseado (1-6)");
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

                case 6:
                    Punto6();
                    break;

                default:
                    break;
            }
        }
        public static void Punto1()
        {
            Console.WriteLine("Escriba tipo de cambio:");
            float tipoDeCambio = float.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el valor a convertir:");
            float valorAConvertir = float.Parse(Console.ReadLine());

            float valorConvertido = valorAConvertir * tipoDeCambio;
            Console.WriteLine("El valor convertido es de: " + valorConvertido);
        }
        public static void Punto2()
        {
            int numeroSelectorCalculadora = MenuCalculadora();
            Console.WriteLine("Ingrese primer numero:");
            double primerNumero = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero:");
            double segundoNumero = double.Parse(Console.ReadLine());

            switch (numeroSelectorCalculadora)
            {
                case 1:
                    Console.WriteLine("El resultado es: " + Suma(primerNumero, segundoNumero));
                    break;

                case 2:
                    Console.WriteLine("El resultado es: " + Resta(primerNumero, segundoNumero));
                    break;

                case 3:
                    Console.WriteLine("El resultado es: " + Multiplicacion(primerNumero, segundoNumero));
                    break;

                case 4:
                    Console.WriteLine("El resultado es: " + Division(primerNumero, segundoNumero));
                    break;

                default:
                    break;
            }

            
            static int MenuCalculadora()
            {
                Console.WriteLine("1- Suma");
                Console.WriteLine("2- Resta");
                Console.WriteLine("3- Multiplicacion");
                Console.WriteLine("4- Division");

                return int.Parse(Console.ReadLine());
            }
            static double Suma(double numero1, double numero2)
            {
                return (numero1+numero2);
            }
            static double Resta(double numero1, double numero2)
            {
                return (numero1 - numero2);
            }
            static double Multiplicacion(double numero1, double numero2)
            {
                return (numero1 * numero2);
            }
            static double Division(double numero1, double numero2)
            {
                return (numero1 / numero2);
            }
        }
        public static void Punto3()
        {

        }
        public static void Punto4()
        {

        }
        public static void Punto5()
        {

        }
        public static void Punto6()
        {

        }
    }
}
