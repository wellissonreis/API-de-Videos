using ApiDeVideos.Data.Dtos.Video;
using ApiDeVideos.Models;
using AutoMapper;

namespace ApiDeVideos.Profiles;

public class VideoProfile : Profile
{
    public VideoProfile()
    {
        CreateMap<CreateVideoDto, Videos>();

        CreateMap<UpdateVideoDto, Videos>();
        CreateMap<Videos, UpdateVideoDto>();

        CreateMap<ReadVideoDto, Videos>();

        CreateMap<Videos, ReadVideoDto>()
            .ForMember(videoDto => videoDto.ReadCategoria, opt => opt.MapFrom(video => video.Categorias));
    }
}
