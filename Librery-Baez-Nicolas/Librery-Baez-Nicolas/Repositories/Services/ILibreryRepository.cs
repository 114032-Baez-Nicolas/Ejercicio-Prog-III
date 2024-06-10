using Librery_Baez_Nicolas.Dtos;
using Librery_Baez_Nicolas.Models;
namespace Librery_Baez_Nicolas.Repositories.Services;

public interface ILibreryRepository
{
    //Obtener Autores
    Task<List<Autor>> GetAutoresAsync();
    //Obtener Generos
    Task<List<Genero>> GetGenerosAsync();
    //Obtener Libros
    Task<List<Libro>> GetLibrosAsync();

    //Post (Crear Libros)
    Task<Libro> PostLibroAsync(Libro lLibro);

    //Put (Actualizar Libros)
    Task<Libro> PutLibroAsync(Libro lLibro);

    //Delete (Eliminar Libros)
    Task DeleteLibroAsync(int ISBN);
}
