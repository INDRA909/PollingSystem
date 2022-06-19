using Microsoft.AspNetCore.Authentication.Cookies;
using PollingSystem.Web.Definitions.Base;

namespace PollingSystem.Web.Definitions.Identity
{
    public class IdentityDefinition: AppDefinition
    {
        public override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(config =>
                {
                    config.LoginPath = "/Admin/Login";
                });
        }
    }
}
