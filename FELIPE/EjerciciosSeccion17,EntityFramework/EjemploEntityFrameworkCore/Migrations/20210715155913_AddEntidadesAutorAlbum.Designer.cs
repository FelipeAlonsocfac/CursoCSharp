﻿// <auto-generated />
using System;
using EjemploEntityFrameworkCore.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EjemploEntityFrameworkCore.Migrations
{
    [DbContext(typeof(ContextoDB))]
    [Migration("20210715155913_AddEntidadesAutorAlbum")]
    partial class AddEntidadesAutorAlbum
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EjemploEntityFrameworkCore.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlbumId");

                    b.ToTable("Albumes");
                });

            modelBuilder.Entity("EjemploEntityFrameworkCore.Models.Autor", b =>
                {
                    b.Property<int>("AutorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AutorId");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("EjemploEntityFrameworkCore.Models.Cancion", b =>
                {
                    b.Property<int>("CancionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int>("AutorId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<TimeSpan>("Duracion")
                        .HasColumnType("time");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CancionId");

                    b.HasIndex("AlbumId");

                    b.HasIndex("AutorId")
                        .IsUnique();

                    b.ToTable("Canciones");
                });

            modelBuilder.Entity("EjemploEntityFrameworkCore.Models.Cancion", b =>
                {
                    b.HasOne("EjemploEntityFrameworkCore.Models.Album", "Album")
                        .WithMany("Canciones")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EjemploEntityFrameworkCore.Models.Autor", "Autor")
                        .WithOne("Cancion")
                        .HasForeignKey("EjemploEntityFrameworkCore.Models.Cancion", "AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("Autor");
                });

            modelBuilder.Entity("EjemploEntityFrameworkCore.Models.Album", b =>
                {
                    b.Navigation("Canciones");
                });

            modelBuilder.Entity("EjemploEntityFrameworkCore.Models.Autor", b =>
                {
                    b.Navigation("Cancion");
                });
#pragma warning restore 612, 618
        }
    }
}
