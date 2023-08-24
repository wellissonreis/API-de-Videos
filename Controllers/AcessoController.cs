using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiDeVideos.Controllers;

[ApiController]
[Route("[controller]")]
public class AcessoController : ControllerBase
{
    [HttpGet("Admin")]
    [Authorize(Roles = "1" )]
    public IActionResult Admin()
    {
        return Ok("Acesso admin Permitido"); 
    }

    [HttpGet("Gerente")]
    [Authorize(Roles = "1,2")]
    public IActionResult Gerente()
    {
        return Ok("Acesso Gerente Permitido");
    }

    [HttpGet("Usuario")]
    [Authorize(Roles = "1,2,3")]
    public IActionResult Usuario()
    {
        return Ok("Acesso Usuario Permitido");
    }

    [HttpGet("visitante")]
    [AllowAnonymous]
    public IActionResult admiradores()
    {
        return Ok("Acesso permitido para qualquer visitante");
    }

}
