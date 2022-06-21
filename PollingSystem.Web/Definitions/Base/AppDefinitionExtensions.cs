namespace PollingSystem.Web.Definitions.Base;
public static class AppDefinitionExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="source"></param>
    /// <param name="builder"></param>
    /// <param name="entryPointsAssembly"></param>
    public static void AddDefinition(this IServiceCollection source, WebApplicationBuilder builder,
        params Type[] entryPointsAssembly)
    {
        var definitions = new List<IAppDefinition>();
        foreach (var entryPoint in entryPointsAssembly)
        {
            var types = entryPoint.Assembly.ExportedTypes.Where(t => !t.IsAbstract && typeof(IAppDefinition).IsAssignableFrom(t));
            var instances = types.Select(Activator.CreateInstance).Cast<IAppDefinition>();
            definitions.AddRange(instances);
        }
        definitions.ForEach(app => app.ConfigureServices(source, builder.Configuration));
        source.AddSingleton(definitions as IReadOnlyCollection<IAppDefinition>);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sourсe"></param>
    public static void UseDefinitions(this WebApplication sourсe)
    {
        var definitions = sourсe.Services.GetRequiredService<IReadOnlyCollection<IAppDefinition>>();
        var environment = sourсe.Services.GetRequiredService<IWebHostEnvironment>();
        foreach (var endpoint in definitions)
        {
            endpoint.ConfigureApplication(sourсe, environment);
        }
    }
}


