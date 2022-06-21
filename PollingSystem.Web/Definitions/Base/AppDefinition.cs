namespace PollingSystem.Web.Definitions.Base;
public abstract class AppDefinition : IAppDefinition
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    public virtual  void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
            
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="app"></param>
    /// <param name="environment"></param>
    public virtual void ConfigureApplication(WebApplication app, IWebHostEnvironment environment)
    {

    }
}