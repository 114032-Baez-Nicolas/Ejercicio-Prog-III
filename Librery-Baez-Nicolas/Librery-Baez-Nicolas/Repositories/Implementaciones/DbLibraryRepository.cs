using Librery_Baez_Nicolas.Context;
using Librery_Baez_Nicolas.Dtos;
using Librery_Baez_Nicolas.Models;
using Librery_Baez_Nicolas.Repositories.Services;
using Microsoft.EntityFrameworkCore;

namespace Librery_Baez_Nicolas.Repositories.Implementaciones;

public class DbLibraryRepository : ILibreryRepository
{
    private readonly LibraryDbContext _context;

    public DbLibraryRepository(LibraryDbContext lContext)
    {
        _context = lContext;

    }

    //Obtener Autores
    public Task<List<Autor>> GetAutoresAsync()
    {
        return _context.DbSetAutores.ToListAsync();
    }

    //Obtener Generos
    public Task<List<Genero>> GetGenerosAsync()
    {
        return _context.DbSetGeneros.ToListAsync();
    }

    //Obtener Libros
    public Task<List<Libro>> GetLibrosAsync()
    {
        return _context.DbSetLibros.ToListAsync();
    }

    //Post (Crear Libros)
    public async Task<Libro> PostLibroAsync(Libro lLibro)
    {
        try
        {
            await _context.DbSetLibros.AddAsync(lLibro);
            await _context.SaveChangesAsync();

            return lLibro;
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    //Put (Actualizar Libros)
    public async Task<Libro> PutLibroAsync(Libro lLibro)
    {
        try
        {
            _context.DbSetLibros.Update(lLibro);
            await _context.SaveChangesAsync();

            return lLibro;
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    //Delete (Eliminar Libros)
    public async Task DeleteLibroAsync(int ISBN)
    {
        try
        {
            var lLibro = await _context.DbSetLibros.FindAsync(ISBN);
            _context.DbSetLibros.Remove(lLibro);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw;
        }
    }

}
