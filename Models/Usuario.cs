﻿using Microsoft.AspNetCore.Identity;

namespace ApiDeVideos.Models
{
    public class Usuario : IdentityUser
    {
        public string DataNascimento { get; set; }
        public int PerfilUsuario { get; set; }
        public Usuario() : base() { }
    }
}

