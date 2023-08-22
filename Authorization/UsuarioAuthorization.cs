using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

namespace ApiDeVideos.Authorization;

public class UsuarioAuthorization : AuthorizationHandler<PerfilUsuario>
{

    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PerfilUsuario requirement)
    {
        var adminClaim = context.User.FindFirst(
            claim => claim.Type == ClaimTypes.SerialNumber);

        var usuario = Convert.ToInt32(adminClaim);

      
        if(usuario == 1)
        {
            context.Succeed(requirement);
        }

        if (adminClaim is null) { return Task.CompletedTask; }

        return Task.CompletedTask;  

    }
}