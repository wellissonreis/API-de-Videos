using Alura_Challenge_Backend_Semana_1.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Alura_Challenge_Backend_Semana_1.Data.Dtos.Categoria
{
    public class ReadCategoriaDto
    {
        public string Titulo { get; set; }
        public string Cor { get; set; }
    }
}
