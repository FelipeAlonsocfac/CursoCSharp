using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSeccion11
{
    class ClaseGenerica<T>
    {
        public List<T> genList = new List<T>();
        public void Add(T valor)
        {
            genList.Add(valor);
        }
    }
}
