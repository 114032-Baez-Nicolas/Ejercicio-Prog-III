using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Librery_Baez_Nicolas.Models;

public class Libro
{
    [Key]
    public int ISBN { get; set; }

    [Required]
    public string Titulo { get; set; }
    public DateTime FechaPublicacion { get; set; }

    [ForeignKey("lAutorId")]
    public int lAutorId { get; set; }   

    [ForeignKey("lGeneroId")]
    public int lGeneroId { get; set; }
}
