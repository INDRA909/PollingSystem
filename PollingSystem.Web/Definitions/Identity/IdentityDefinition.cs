using Microsoft.AspNetCore.Authentication.Cookies;
using PollingSystem.Web.Definitions.Base;
namespace PollingSystem.Web.Definitions.Identity;
public class IdentityDefinition : AppDefinition
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    public override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(config =>
            {
                config.LoginPath = "/Admin/Login";
            });
    }
}

