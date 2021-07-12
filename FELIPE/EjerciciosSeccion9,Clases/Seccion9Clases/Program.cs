using System;
using System.Collections.Generic;

namespace Seccion9Clases
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
            Console.WriteLine("Introduzca a 5 personas.");
            var personas = new List<Persona>();
            string nombre;
            uint edad;
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Nombre Persona {i+1}: ");
                nombre = Console.ReadLine();
                Console.Write($"Edad Persona {i + 1}: ");
                edad = uint.Parse(Console.ReadLine());
                personas.Add(new Persona { nombre = nombre, edad = edad });
                Console.WriteLine("");
            }
            Console.WriteLine("Las personas mayores de edad son: ");
            foreach (var item in personas)
            {
                if (item.edad >= 18)
                {
                    Console.WriteLine(item.nombre);
                }
            }
        }
        public static void Ej2() {
            Console.WriteLine("Introduzca a 5 personas.");
            var profesores = new List<Profesor>();
            var alumnos = new List<Alumno>();
            string nombre;
            uint edad;
            uint  tipo;
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Nombre Persona {i + 1}: ");
                nombre = Console.ReadLine();
                Console.Write($"Edad Persona {i + 1}: ");
                edad = uint.Parse(Console.ReadLine());
                Console.WriteLine("1. Alumno\n2. Profesor");
                tipo = uint.Parse(Console.ReadLine());
                if (tipo == 1)
                {
                    Console.Write("Introduzca su codigo: ");
                    alumnos.Add(new Alumno
                    {
                        nombre = nombre,
                        edad = edad,
                        codigo = uint.Parse(Console.ReadLine())
                    });
                }
                else if (tipo == 2)
                {
                    Console.Write("Introduzca su asignatura: ");
                    profesores.Add(new Profesor
                    {
                        nombre = nombre,
                        edad = edad,
                        asignatura = Console.ReadLine()
                    });
                }
                else {
                    Console.WriteLine("Tipo incorrecto.");
                    i -= 1;
                }
            }

            Console.WriteLine("Las personas mayores de edad son: ");
            foreach (var item in profesores)
            {
                if (item.edad >= 18)
                {
                    Console.WriteLine(item.nombre);
                }
            }
            foreach (var item in alumnos)
            {
                if (item.edad >= 18)
                {
                    Console.WriteLine(item.nombre);
                }
            }
        }
        public static void Ej3()
        {
            Avion avion = new Avion();
            Barco barco = new Barco();
            Coche coche = new Coche();

            Console.WriteLine($"El consumo por kilometro del avion es de: {avion.Consumo()}, el del barco es de: {barco.Consumo()} y " +
                              $" el del coche es de {coche.Consumo()}");
            Console.WriteLine($"Al preguntar si el vehiculo tiene ruedas, tenemos que: \n" +
                              $" Avion: {avion.TieneRuedas()}\n" +
                              $" Barco: {barco.TieneRuedas()}\n" +
                              $" Coche: {coche.TieneRuedas()}");
            Console.WriteLine($"La velocidad maxima de cada vehiculo en km/h es de:\n" +
                              $" Avion: {avion.VelocidadMax()}\n" +
                              $" Barco: {barco.VelocidadMax()}\n" +
                              $" Coche: {coche.VelocidadMax()}");
        }
        public static void Ej4()
        {
            Vehiculo_ej4 vehiculo1 = new Vehiculo_ej4(); 
            Vehiculo_ej4 vehiculo2 = new Vehiculo_ej4(2); 
            Vehiculo_ej4 vehiculo3 = new Vehiculo_ej4(12, 2);
            Console.WriteLine($"El primer vehiculo tiene: {vehiculo1.ruedas} ruedas y {vehiculo1.puertasPrivadas} puertas\n" +
                              $" El segundo vehiculo tiene: {vehiculo2.ruedas} ruedas y {vehiculo2.puertasPrivadas} puertas\n" +
                              $"  El tercer vehiculo tiene: {vehiculo3.ruedas} ruedas y {vehiculo3.puertasPrivadas} puertas\n");
        }
        public static void Ej5()
        {
            Console.WriteLine($"La suma de 213 mas 12321 da {Producto.Suma(213, 12321)}");

        }
        public static void Ej6()
        {

            Animal animal1 = new Animal
            {
                Tipo = "Perro",
                ColorPelo = "Miel",
                EsDomestico = true,
                NumeroPatas = 4
            };

            Animal animal2 = new Animal
            {
                Tipo = "Tarantula",
                ColorPelo = "Negro",
                EsDomestico = true,
                NumeroPatas = 8
                
            };
            Console.WriteLine("\nAnimal 1:");
            RecorrerAnimal(animal1);
            Console.WriteLine("\nAnimal 2:");
            RecorrerAnimal(animal2);

            void RecorrerAnimal(Animal animal) {
                Console.WriteLine($"Tipo de animal: {animal.Tipo}\n" +
                                  $"Color de pelo: {animal.ColorPelo}\n" +
                                  $"Es domestico?: {animal.EsDomestico}\n" +
                                  $"# de patas: {animal.NumeroPatas}\n");
            }
        }
    }
}
