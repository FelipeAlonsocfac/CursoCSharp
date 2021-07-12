using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSeccion10
{
    class Animal : IAnimal
    {
        public void Andar()
        {
            Console.WriteLine("Andando...");
        }

        public bool EsPerro()
        {
            return true;
        }

        public void Saltar()
        {
            Console.WriteLine("Saltando...");
        }
    }
}
