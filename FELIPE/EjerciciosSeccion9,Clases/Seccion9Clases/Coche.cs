using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion9Clases
{
    class Coche : Vehiculo
    {
        public override int Consumo()
        {
            int consumo = 10;

            return consumo;
        }

        public override bool TieneRuedas()
        {
            return true;
        }

        public override int VelocidadMax()
        {
            int velocidadmax = 120;

            return velocidadmax;
        }
    }
}
