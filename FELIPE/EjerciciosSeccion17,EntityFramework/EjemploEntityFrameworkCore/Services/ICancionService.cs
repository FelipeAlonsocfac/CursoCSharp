using EjemploEntityFrameworkCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploEntityFrameworkCore.Services
{
    public interface ICancionService
    {

        void AddCancion(Cancion cancion);
        void DeleteCancion(int CancionId);
        void DeleteCancion(Cancion cancion);

        List<Cancion> GetCanciones();

        Cancion GetCancion(int CancionId);

        Cancion UpdateCancion(Cancion cancion);
    }
}
