using EjemploEntityFrameworkCore.EntityConfig;
using EjemploEntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploEntityFrameworkCore.Contexto
{
    public class ContextoDB : DbContext, IContextoDB
    {

        public ContextoDB(DbContextOptions<ContextoDB> options) : base(options) {


        }

        public DbSet<Cancion> Canciones{get; set;}  //nombre con el que se va a crear mi tabla
        public DbSet<Album> Albumes { get; set; }
        public DbSet<Autor> Autores { get; set; }


        protected  override void OnModelCreating(ModelBuilder modelBuilder) {

            CancionEntityConfig.SetCancionEntityConfig(modelBuilder.Entity<Cancion>());



            //modelBuilder.Entity<Cancion>().ToTable("Canciones"); //asi tambien se pone el nombre que va a tener mi tabla

            
        }

    }
}
 