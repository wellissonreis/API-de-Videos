using Alura_Challenge_Backend_Semana_1.Data.Dtos.Categoria;
using System.ComponentModel.DataAnnotations;

namespace Alura_Challenge_Backend_Semana_1.Data.Dtos.Video;

public class ReadVideoDto
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public string Url { get; set; }
    public ReadCategoriaDto Categorias { get; set; }
}
