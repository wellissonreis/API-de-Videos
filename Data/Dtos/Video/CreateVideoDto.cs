using ApiDeVideos.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiDeVideos.Data.Dtos.Video;

public class CreateVideoDto
{
    [Required(ErrorMessage = "Titulo não inserido, por favor forneça um título!")]
    [MaxLength(100)]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "Descreva o vídeo.")]
    [MaxLength(255)]
    public string Descricao { get; set; }
    [Required(ErrorMessage = "Sem a URL, infelizmente não é possível compartilhar um vídeo!")]
    public string Url { get; set; }

    //Referencia
    public int CategoriasId { get; set; }
}
