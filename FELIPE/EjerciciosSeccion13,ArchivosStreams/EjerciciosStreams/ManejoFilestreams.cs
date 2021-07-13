using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosStreams
{
    class ManejoFilestreams
    {
        FileStream mainFs;

        public ManejoFilestreams() {
            FileStream inicializacion = new FileStream("Personas.txt", FileMode.OpenOrCreate);
            inicializacion.Close();
        }
        public Persona Add() {

            Persona personaActual = new Persona();

            string otraPersona;

            mainFs = new FileStream("Personas.txt", FileMode.Append);

            while (true)    //se queda hasta que haya un break, este lo hay cuando ya no se quieren añadir a mas personas
            {

                Console.WriteLine("Introduzca nombre de la persona a registrar\n");
                personaActual.nombre = Console.ReadLine();

                Console.WriteLine("Introduzca edad de la persona a registrar\n");


                int result; //resultado de un parse exitoso

                while (!int.TryParse(Console.ReadLine(), out result))  //si no funciona el parse, reintentarlo
                {
                    Console.WriteLine("Valor incorrecto");
                    Console.WriteLine("Introduzca edad de la persona a registrar\n");
                }

                personaActual.edad = result;

                Console.WriteLine("Introduzca localidad de la persona a registrar");
                personaActual.localidad = Console.ReadLine();

                string persona = $"{personaActual.nombre}|{personaActual.edad}|{personaActual.localidad};";

                mainFs.Write(ASCIIEncoding.ASCII.GetBytes(persona), 0, persona.Length);

                while (true)    //while para asegurarse que recibe S o N
                {
                    Console.WriteLine("Quieres introducir otra persona?(S/N)");
                    otraPersona = Console.ReadLine().ToUpper();
                    if (otraPersona == "S" || otraPersona == "N") break;
                    Console.WriteLine("Valor incorrecto.\n");
                }
                if (otraPersona == "N") //si no se quiere añadir otra persona, que salga del while
                {
                    break;
                }
            }
            mainFs.Close();
            return personaActual;
        }

        public List<Persona> Get() {
            byte[] infoArchivo = new byte[50000];
            List<Persona> listaPersonas = new List<Persona>();

            mainFs = new FileStream("Personas.txt", FileMode.Open);
            mainFs.Read(infoArchivo, 0, (int)mainFs.Length);
            mainFs.Close();

            var archivo = ASCIIEncoding.ASCII.GetString(infoArchivo);

            var personas = archivo.Split(';').ToList();

            personas.RemoveAt(personas.Count - 1);

            foreach (var item in personas)
            {
                listaPersonas.Add(ExtractPersona(item));
            }
            return listaPersonas;
        }
        private Persona ExtractPersona(string linea)
        {

            var persona = linea.Split('|');

            return new Persona
            {
                nombre = persona[0],
                edad = int.Parse(persona[1]),
                localidad = persona[2]
                
            };
        }

    }
}
