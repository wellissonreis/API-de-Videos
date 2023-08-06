using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Alura_Challenge_Backend_Semana_1.Models;

public class Categorias
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "Insira o Título da categoria")]
    public string Titulo { get; set; }
    [DefaultValue ("#FFFFFF")]
    public string Cor { get; set;}
    public virtual Videos Videos { get; set; }
}
