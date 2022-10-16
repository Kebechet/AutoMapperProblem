using AutoMapper;

namespace ApiTest.Config;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<TrainingSetDto, TrainingSetDto>();
    }
}
