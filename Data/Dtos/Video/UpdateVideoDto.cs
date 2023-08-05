using System.ComponentModel.DataAnnotations;

namespace Alura_Challenge_Backend_Semana_1.Data.Dtos.Video;

public class UpdateVideoDto
{
    [Required(ErrorMessage = "Titulo não inserido, por favor forneça um título!")]
    [MaxLength(100)]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "Descreva o vídeo.")]
    [StringLength(255)]
    public string Descricao { get; set; }
    [Required(ErrorMessage = "Sem a URL, infelizmente não é possível compartilhar um vídeo!")]
    public string Url { get; set; }
}
