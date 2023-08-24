using ApiDeVideos.Data.Dtos.Usuario;
using ApiDeVideos.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ApiDeVideos.Services
{
    public class UsuarioServices
    {

        private IMapper _mapper;
        private UserManager<Usuario> _userManager;
        private SignInManager<Usuario> _signInManager;
        private TokenService _tokenService;


        public UsuarioServices(IMapper mapper, UserManager<Usuario> userManager, SignInManager<Usuario> signInManager, TokenService tokenService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        public async Task CadastraUsuario(CreateUsuarioDto dto)
        {
            Usuario usuario = _mapper.Map<Usuario>(dto);
            IdentityResult resultado = await _userManager.CreateAsync(usuario, dto.Password);

            if (!resultado.Succeeded) throw new ApplicationException("Falha ao cadastrar Usuario");
        }

        public async Task<string> Login(LoginUsuarioDto dto)
        {
            var resultado = await _signInManager.PasswordSignInAsync(dto.Username, dto.Password, false, false);

            if (!resultado.Succeeded) throw new ApplicationException("Usuário não autenticado");

            var usuario = _userManager.Users.FirstOrDefault(user => user.NormalizedUserName
            == dto.Username.ToUpper());

            string token = _tokenService.GenerateToken(usuario);

            return token;

        }



    }
}
