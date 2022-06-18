using Microsoft.EntityFrameworkCore;
using PollingSystem.Application;
using PollingSystem.Web.Definitions.Base;

namespace PollingSystem.Web.Definitions.DbContext;
public class DbContextDefinition : AppDefinition
{
    public override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString(nameof(ApplicationDbContext)));
        });
    }

}

