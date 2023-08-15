using ApiDeVideos.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ApiDeVideos.Data.Dtos.Categoria
{
    public class UpdateCategoriaDto
    {
        [Required(ErrorMessage = "Insira o Título da categoria")]
        public string Titulo { get; set; }
        [DefaultValue("#FFFFFF")]
        public string Cor { get; set; }
    }
}
