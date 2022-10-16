using ApiTest;
using AutoMapper;

namespace ApiTest.Extensions.DependencyInstallers.Mapping.Profiles;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<TrainingSetDto, TrainingSetDto>();
    }
}
