using System.ComponentModel.DataAnnotations;

namespace ApiDeVideos.Data.Dtos.Usuario;

public class LoginUsuarioDto
{
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
}
