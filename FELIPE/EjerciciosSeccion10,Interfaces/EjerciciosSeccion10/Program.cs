using System;

namespace EjerciciosSeccion10
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            animal.Andar();
            animal.Saltar();
            Console.WriteLine($"\nEs perro?: {animal.EsPerro()}");
        }
    }
}
