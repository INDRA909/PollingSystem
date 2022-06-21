using PollingSystem.Web.Definitions.Base;
namespace PollingSystem.Web.Definitions.Blazors;
public class BlazorDefinition : AppDefinition
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    public override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddServerSideBlazor();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="app"></param>
    /// <param name="environment"></param>
    public override void ConfigureApplication(WebApplication app, IWebHostEnvironment environment)
    {
        app.MapBlazorHub();
    }
}
