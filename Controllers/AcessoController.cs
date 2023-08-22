using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiDeVideos.Controllers;

[ApiController]
[Route("[controller]")]
public class AcessoController : ControllerBase
{
    [HttpGet]
    [Authorize(Policy = "PerfilUsuario")]
    public IActionResult Get()
    {
        return Ok("Acesso Permitido"); 
    }
}
