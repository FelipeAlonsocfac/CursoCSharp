using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioHuevosPericos
{
    public class Huevos
    {

    }

    public class Guiso
    {

    }

    public class Arepa
    {

    }

    class Program
    {

        static async Task Main(string[] args)
        {
            
            var tomatOnionTask = FreirTomateCebolla(2,1);
            var arepaTask = AsarArepa(2);

            var allTasks = new List<Task> { tomatOnionTask, arepaTask };
            
            while (allTasks.Any())
            {
                Task finished = await Task.WhenAny(allTasks);
                if (finished == arepaTask)
                {
                    Console.WriteLine("arepas are ready");
                    allTasks.Remove(arepaTask);
                    var arepa = await arepaTask;
                }
                else if (finished == tomatOnionTask)
                {
                    Console.WriteLine("Guiso is ready");
                    allTasks.Remove(tomatOnionTask);
                    var bacon = await tomatOnionTask;
                    var eggsTask = FreirHuevos(3);
                    var eggs = await eggsTask;
                }
                else
                    allTasks.Remove(finished);
            }
            Console.WriteLine("pericos is ready!");

        }

        public static async Task<Huevos> FreirHuevos(int numHuevos)
        {
            return new Huevos();
        }

        public static async Task<Guiso> FreirTomateCebolla(int numTomates, int numCebollas)
        {
            return new Guiso();
        }
        public static async Task<Arepa> AsarArepa(int numArepas)
        {
            return new Arepa();
        }
    }
}
