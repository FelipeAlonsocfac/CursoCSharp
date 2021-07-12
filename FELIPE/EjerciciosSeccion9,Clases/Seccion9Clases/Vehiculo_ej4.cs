using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion9Clases
{
    class Vehiculo_ej4
    {
        public int ruedas { get; private set; }
        public int puertasPrivadas { get; private set; }

        public Vehiculo_ej4() {
            ruedas = 4;
            puertasPrivadas = 4;
        }
        public Vehiculo_ej4(int nRuedas) {
            ruedas = nRuedas;
        }
        public Vehiculo_ej4(int nRuedas, int nPuertas)
        {
            ruedas = nRuedas;
            puertasPrivadas = nPuertas;
        }
    }
}
