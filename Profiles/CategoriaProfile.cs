using Alura_Challenge_Backend_Semana_1.Data.Dtos.Categoria;
using Alura_Challenge_Backend_Semana_1.Models;
using AutoMapper;

namespace Alura_Challenge_Backend_Semana_1.Profiles
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
