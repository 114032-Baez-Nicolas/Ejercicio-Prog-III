using Librery_Baez_Nicolas.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
namespace Librery_Baez_Nicolas.Context;

public class LibraryDbContext : DbContext
{
    public LibraryDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {
    }

    public DbSet<Autor> DbSetAutores { get; set; }
    public DbSet<Genero> DbSetGeneros { get; set; }
    public DbSet<Libro> DbSetLibros { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Autor>().HasData(
                       new Autor { Id = 1, Nombre = "Charles Darwin", FechaNacimiento = new DateTime(1809, 2, 12)},
                       new Autor { Id = 2, Nombre = "Stephen King", FechaNacimiento = new DateTime(1947, 9, 21)},
                       new Autor { Id = 3, Nombre = "Margaret Atwood", FechaNacimiento = new DateTime(1939, 11, 18) },
                       new Autor { Id = 4, Nombre = "J. K. Rowling", FechaNacimiento = new DateTime(1965, 7, 31) }
                       );

        modelBuilder.Entity<Genero>().HasData(
                       new Genero { Id = 1, Nombre = "Fantasía" },
                       new Genero { Id = 2, Nombre = "Romántica" },
                       new Genero { Id = 3, Nombre = "Terror" },
                       new Genero { Id = 4, Nombre = "Aventuras" }
                       );

        modelBuilder.Entity<Libro>().HasData(
                       new Libro 
                       {
                           ISBN = 1, Titulo = "Harry Potter y el cáliz de fuego",
                           FechaPublicacion = new DateTime(2000, 7, 8), lAutorId = 4, lGeneroId = 1
                       },
                       new Libro
                       {
                           ISBN = 2, Titulo = "It",
                           FechaPublicacion = new DateTime(1986, 9, 15), lAutorId = 2, lGeneroId = 3
                       });
    }
}