using Alura_Challenge_Backend_Semana_1.Data.Dtos.Video;
using Alura_Challenge_Backend_Semana_1.Models;
using AutoMapper;

namespace Alura_Challenge_Backend_Semana_1.Profiles;

public class VideoProfile : Profile
{
    public VideoProfile()
    {
        CreateMap<CreateVideoDto, Videos>();

        CreateMap<UpdateVideoDto, Videos>();
        CreateMap<Videos, UpdateVideoDto>();

        CreateMap<ReadVideoDto, Videos>();
        CreateMap<Videos, ReadVideoDto>();
    }
}
