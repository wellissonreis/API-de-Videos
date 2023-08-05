using Alura_Challenge_Backend_Semana_1.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Alura_Challenge_Backend_Semana_1.Data.Dtos.Categoria
{
    public class UpdateCategoriaDto
    {
        [Required(ErrorMessage = "Insira o Título da categoria")]
        public string Titulo { get; set; }
        [DefaultValue("#FFFFFF")]
        public string Cor { get; set; }
    }
}
