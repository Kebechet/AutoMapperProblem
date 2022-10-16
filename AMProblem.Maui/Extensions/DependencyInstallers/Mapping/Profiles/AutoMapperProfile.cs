using AutoMapper;

namespace AMProblem.Maui.Extensions.DependencyInstallers.Mapping.Profiles;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile() {
        CreateMap<TrainingSetDto, TrainingSetDto>();
    }
}
