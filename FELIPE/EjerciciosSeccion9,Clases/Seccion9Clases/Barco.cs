using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion9Clases
{
    class Barco : Vehiculo
    {
        public override int Consumo()
        {
            int consumo = 20;

            return consumo;
        }

        public override bool TieneRuedas()
        {
            return false;
        }

        public override int VelocidadMax()
        {
            int velocidadmax = 40;

            return velocidadmax;
        }
    }
}
