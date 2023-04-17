using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace GalloFlix.Models;

[Table("Movie")]
public class Movie
{
    [Key]
    // ou [DatabaseGenerated(DatabaseGeneratedOption.Identity)] e None pra nao criar sozinho 
    public int Id { get; set; }

    [Display(Name = "Título Original")]
    // Name: titulo e prompt: placeholder
    [Required(ErrorMessage = "O Título Original é obrigatório!")]
    [StringLength(100, ErrorMessage = "O Título Original deve possuir no máximo 100 caracteres")]
    public string OriginalTitle { get; set; }

    [Display(Name = "Título")]
    // Name: titulo e prompt: placeholder
    [Required(ErrorMessage = "O Título é obrigatório!")]
    [StringLength(100, ErrorMessage = "O Título deve possuir no máximo 100 caracteres")]
    public string Title { get; set; }

    [Display(Name = "Sinopse")]
    // Name: titulo e prompt: placeholder
    [StringLength(5000, ErrorMessage = "A Sinopse deve possuir no máximo 5000 caracteres")]
    public string Synopsis { get; set; }

    public int MovieYear { get; set; }

    public int Duration { get; set; }

    public int AgeRating { get; set; }

    public string Image { get; set; }
}
