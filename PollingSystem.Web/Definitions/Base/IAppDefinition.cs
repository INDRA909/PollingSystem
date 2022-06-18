namespace PollingSystem.Web.Definitions.Base
{
    //
    public interface IAppDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        void ConfigureServices(IServiceCollection services, IConfiguration configuration);
        /// <summary>
        /// </summary>
        /// <param name="app"></param>
        /// <param name="environment"></param>
        void ConfigureApplication(WebApplication app, IWebHostEnvironment environment);
    }
}
