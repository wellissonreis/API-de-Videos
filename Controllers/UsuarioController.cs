
using ApiDeVideos.Data.Dtos.Usuario;
using ApiDeVideos.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiDeVideos.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    private UsuarioServices _usuarioServices;

    public UsuarioController(UsuarioServices cadastroServices)
    {
        _usuarioServices = cadastroServices;
    }

    [HttpPost("cadastro")]
    public async Task<IActionResult> CadastraUsuario(CreateUsuarioDto dto)
    {
        await _usuarioServices.CadastraUsuario(dto);
        return Ok("Usuario Cadastrado");
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginUsuarioDto dto)
    {
        string token = await _usuarioServices.Login(dto);
        return Ok("Seu Token é: " + token);
    }
}
