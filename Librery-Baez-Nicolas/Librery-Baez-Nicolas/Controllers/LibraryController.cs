using Librery_Baez_Nicolas.Dtos;
using Librery_Baez_Nicolas.Models;
using Librery_Baez_Nicolas.Repositories.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Librery_Baez_Nicolas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        //Inyeccion de dependencias
        private readonly ILibreryRepository _libreryRepository;

        public LibraryController(ILibreryRepository libreryRepository)
        {
            _libreryRepository = libreryRepository;
        }

        //Obtener Autores
        [HttpGet("autores")]
        public async Task<IActionResult> GetAutores()
        {
            var lAutores = await _libreryRepository.GetAutoresAsync();

            return Ok(lAutores);
        }

        //Obtener Generos
        [HttpGet("generos")]
        public async Task<IActionResult> GetGeneros()
        {
            var lGeneros = await _libreryRepository.GetGenerosAsync();

            return Ok(lGeneros);
        }

        //Obtener Libros
        [HttpGet("libros")]
        public async Task<IActionResult> GetLibros()
        {
            var lLibros = await _libreryRepository.GetLibrosAsync();

            return Ok(lLibros);
        }

        //Post (Crear Libros)
        [HttpPost]
        public async Task<IActionResult> PostLibro([FromBody] Libro dto)
        {
            dto.ISBN = 0;
            var lLibro = await _libreryRepository.PostLibroAsync(dto);

            return Ok(lLibro);
        }

        //Put (Actualizar Libros)
        [HttpPut]
        public async Task<IActionResult> PutLibro([FromBody] Libro dto)
        {
            var lLibro = await _libreryRepository.PutLibroAsync(dto);

            return Ok(lLibro);
        }

        //Delete (Eliminar Libros)
        [HttpDelete("{ISBN}")]
        public async Task<IActionResult> DeleteLibro(int ISBN)
        {
            await _libreryRepository.DeleteLibroAsync(ISBN);

            return Ok();
        }

        //Obtener Autores x Id
        [HttpGet("autores/{Id}")]
        public async Task<IActionResult> GetAutor(int Id)
        {
            var lAutor = await _libreryRepository.GetAutorAsync(Id);

            return Ok(lAutor);
        }

        //Obtener Generos x Id
        [HttpGet("generos/{Id}")]
        public async Task<IActionResult> GetGenero(int Id)
        {
            var lGenero = await _libreryRepository.GetGeneroAsync(Id);

            return Ok(lGenero);
        }

        //Obtener Libros x ISBN
        [HttpGet("libros/{ISBN}")]
        public async Task<IActionResult> GetLibro(int ISBN)
        {
            var lLibro = await _libreryRepository.GetLibroAsync(ISBN);

            return Ok(lLibro);
        }
    }
}