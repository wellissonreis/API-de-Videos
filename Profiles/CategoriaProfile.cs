using ApiDeVideos.Data.Dtos.Categoria;
using ApiDeVideos.Models;
using AutoMapper;

namespace ApiDeVideos.Profiles
{
    public class CategoriaProfile : Profile
    {
        public CategoriaProfile()
        {
            CreateMap<CreateCategoriaDto, Categorias>();
            CreateMap<Categorias, CreateCategoriaDto>();

            CreateMap<ReadCategoriaDto, Categorias>();
            CreateMap<Categorias, ReadCategoriaDto>();

            CreateMap<Categorias, UpdateCategoriaDto>();
            CreateMap<UpdateCategoriaDto, Categorias>();

        }
    }
}
