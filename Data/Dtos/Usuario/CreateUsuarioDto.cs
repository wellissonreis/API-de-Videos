using System.ComponentModel.DataAnnotations;

namespace ApiDeVideos.Data.Dtos.Usuario
{
    public class CreateUsuarioDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public int PerfilUsuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string RePassword { get; set; }
    }
}
