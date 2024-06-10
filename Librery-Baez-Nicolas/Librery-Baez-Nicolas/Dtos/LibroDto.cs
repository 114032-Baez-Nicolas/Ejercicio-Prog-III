using Librery_Baez_Nicolas.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Librery_Baez_Nicolas.Dtos;

public class LibroDto
{
    public int ISBN { get; set; }
    public string Titulo { get; set; }
    public DateTime FechaPublicacion { get; set; }
    public int lAutorId { get; set; }
    public int lGeneroId { get; set; }
}
