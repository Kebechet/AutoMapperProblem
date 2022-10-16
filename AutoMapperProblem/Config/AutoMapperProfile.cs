using AutoMapper;
using SatisFIT.Shared.Models.DataTransferObjects.Training;

namespace SatisFIT.Client.App.Extensions.DependencyInstallers.Mapping.Profiles;

public class AutoMapperProfile : Profile {
	public AutoMapperProfile() {
        CreateMap<TrainingSetDto, TrainingSetDto>();
    }
}
