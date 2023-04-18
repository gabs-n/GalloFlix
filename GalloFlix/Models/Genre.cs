using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GalloFlix.Models;

[Table("Genre")]
public class Genre
{
    [Key]
    // ou [DatabaseGenerated(DatabaseGeneratedOption.Identity)] e None pra nao criar sozinho 
    public byte Id { get; set; }

    [Display(Name = "Nome")]
    // Name: titulo e prompt: placeholder
    [Required(ErrorMessage = "O Nome do Gênero é obrigatório!")]
    [StringLength(30, ErrorMessage = "O nome deve possuir no máximo 30 caracteres")]
    public string Name { get; set; }
}
