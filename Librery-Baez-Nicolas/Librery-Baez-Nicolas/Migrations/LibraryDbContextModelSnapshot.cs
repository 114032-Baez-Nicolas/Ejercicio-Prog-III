﻿// <auto-generated />
using System;
using Librery_Baez_Nicolas.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Librery_Baez_Nicolas.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    partial class LibraryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Librery_Baez_Nicolas.Models.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DbSetAutores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FechaNacimiento = new DateTime(1809, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Charles Darwin"
                        },
                        new
                        {
                            Id = 2,
                            FechaNacimiento = new DateTime(1947, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Stephen King"
                        },
                        new
                        {
                            Id = 3,
                            FechaNacimiento = new DateTime(1939, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Margaret Atwood"
                        },
                        new
                        {
                            Id = 4,
                            FechaNacimiento = new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "J. K. Rowling"
                        });
                });

            modelBuilder.Entity("Librery_Baez_Nicolas.Models.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DbSetGeneros");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Fantasía"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Romántica"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Terror"
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Aventuras"
                        });
                });

            modelBuilder.Entity("Librery_Baez_Nicolas.Models.Libro", b =>
                {
                    b.Property<int>("ISBN")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ISBN"));

                    b.Property<DateTime>("FechaPublicacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("lAutorId")
                        .HasColumnType("int");

                    b.Property<int>("lGeneroId")
                        .HasColumnType("int");

                    b.HasKey("ISBN");

                    b.ToTable("DbSetLibros");

                    b.HasData(
                        new
                        {
                            ISBN = 1,
                            FechaPublicacion = new DateTime(2000, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Titulo = "Harry Potter y el cáliz de fuego",
                            lAutorId = 4,
                            lGeneroId = 1
                        },
                        new
                        {
                            ISBN = 2,
                            FechaPublicacion = new DateTime(1986, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Titulo = "It",
                            lAutorId = 2,
                            lGeneroId = 3
                        });
                });
#pragma warning restore 612, 618
        }
    }
}