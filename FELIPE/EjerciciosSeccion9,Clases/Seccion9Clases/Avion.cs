using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion9Clases
{
    class Avion : Vehiculo
    {
        public override int Consumo()
        {
            int consumo = 30;

            return consumo;
        }

        public override bool TieneRuedas()
        {
            return true;
        }

        public override int VelocidadMax()
        {
            int velocidadmax = 800;
            return velocidadmax;
        }
    }
}
