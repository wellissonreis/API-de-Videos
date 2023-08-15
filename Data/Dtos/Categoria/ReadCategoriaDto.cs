using ApiDeVideos.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ApiDeVideos.Data.Dtos.Categoria
{
    public class ReadCategoriaDto
    {
        public string Titulo { get; set; }
        public string Cor { get; set; }
    }
}
