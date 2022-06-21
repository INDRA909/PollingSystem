using Microsoft.EntityFrameworkCore;
using PollingSystem.Application;
using PollingSystem.Web.Definitions.Base;
namespace PollingSystem.Web.Definitions.DbContext;
public class DbContextDefinition : AppDefinition
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    public override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString(nameof(ApplicationDbContext)));
        });
    }

}

