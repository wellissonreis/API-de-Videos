using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Policy;

namespace ApiDeVideos.Authorization;

public class UsuarioFail : IAuthorizationMiddlewareResultHandler
{
    public async Task HandleAsync(RequestDelegate next, HttpContext context, AuthorizationPolicy policy, PolicyAuthorizationResult authorizeResult)
    {

        if (authorizeResult.Forbidden == true)
        {
            await context.Response.WriteAsync("O usuário não tem permissão para acessar este campo");
        }
        else
        {
            await next(context);
        }
    }
}

