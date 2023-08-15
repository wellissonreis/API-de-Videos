using ApiDeVideos.Data.Dtos.Usuario;
using ApiDeVideos.Models;
using AutoMapper;

namespace ApiDeVideos.Profiles;

public class UsuarioProfile : Profile
{
	public UsuarioProfile()
	{
		CreateMap<CreateUsuarioDto, Usuario>();
		CreateMap<Usuario, CreateUsuarioDto>();
    }

    

}
