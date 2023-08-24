using ApiDeVideos.Permissões;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

namespace ApiDeVideos.Authorization;

public class UsuarioAuthorization : AuthorizationHandler<PerfilUsuario>
{
    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PerfilUsuario requirement)
    {
        throw new NotImplementedException();
    }
}