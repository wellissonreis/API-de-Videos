using ApiDeVideos.Data.Dtos.Categoria;
using System.ComponentModel.DataAnnotations;

namespace ApiDeVideos.Data.Dtos.Video;

public class ReadVideoDto
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public string Url { get; set; }
    public ReadCategoriaDto ReadCategoria { get; set; }
}
