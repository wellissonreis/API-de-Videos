using ApiDeVideos.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiDeVideos.Data.Dtos.Categoria
{
    public class CreateCategoriaDto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Insira o Título da categoria")]
        public string Titulo { get; set; }
        [DefaultValue("#FFFFFF")]
        public string Cor { get; set; }
 
    }
}
