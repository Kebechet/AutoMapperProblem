using ApiTest.Config;
using AutoMapper;
using System.Reflection;

namespace ApiTest.Extensions.DependencyInstallers.Mapping;

public static class AutoMapperInstaller
{
    public static IServiceCollection InstallMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(provider => new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new AutoMapperProfile());
            cfg.AddMaps(Assembly.GetExecutingAssembly().GetReferencedAssemblies().Select(x => x.FullName));
        }));

        return services;
    }
}
