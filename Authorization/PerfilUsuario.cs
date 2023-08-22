
using Microsoft.AspNetCore.Authorization;

namespace ApiDeVideos.Authorization;

public class PerfilUsuario : IAuthorizationRequirement
{
    public PerfilUsuario(int admin)
    {
        Admin = admin;
    }
    public int Admin { get; set; }
}
