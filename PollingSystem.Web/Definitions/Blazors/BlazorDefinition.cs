using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PollingSystem.Web.Definitions.Base;

namespace PollingSystem.Web.Definitions.Blazors
{
    public class BlazorDefinition:AppDefinition
    {
        public override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddServerSideBlazor();
        }

        public override void ConfigureApplication(WebApplication app, IWebHostEnvironment environment)
        {
            app.MapBlazorHub();
        }
    }
}
