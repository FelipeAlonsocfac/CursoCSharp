using EjemploEntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EjemploEntityFrameworkCore.Contexto
{
    public interface IContextoDB
    {
        DbSet<Cancion> Canciones { get; set; }

        DbSet<Album> Albumes { get; set; }
        DbSet<Autor> Autores { get; set; }

        int SaveChanges();      //con estos savechanges se pueden hacer materializaciones contra la base de datos
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);

    }
}
