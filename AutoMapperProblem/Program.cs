using AutoMapper;
using SatisFIT.Client.App.Extensions.DependencyInstallers.Mapping.Profiles;
using SatisFIT.Shared.Models.DataTransferObjects.Training;
using System.Reflection;

public class Program
{
    static void Main(string[] args)
    {
        var config = new MapperConfiguration(cfg => {
            cfg.AddProfile(new AutoMapperProfile());
            cfg.AddMaps(Assembly.GetExecutingAssembly().GetReferencedAssemblies().Select(x => x.FullName));
        });

        IMapper _mapper = config.CreateMapper();

        var original = new TrainingSetDto() {
            CreationTime = DateTime.Now.TimeOfDay,
            Id = 948,
            RepCount = 10,
            TagIds = new List<long>() { 14 },
            TrainingExerciseId = 45,
            WeightLiftedKilograms = 10
        };
        var copy = _mapper.Map<TrainingSetDto>(original);

        var originalHashCode = original.GetHashCode();
        var copyHashCode = copy.GetHashCode();
        if (originalHashCode == copyHashCode)
        {
            throw new Exception("Copy was done by reference.");
        }

        Console.WriteLine($"original: {original.GetHashCode()}");
        Console.WriteLine($"copy: {copy.GetHashCode()}");
    }
}