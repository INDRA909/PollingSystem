using PollingSystem.Web.Definitions.Base;
namespace PollingSystem.Web.Definitions.Common;
public class CommonDefinition : AppDefinition
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    public override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddRazorPages();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="app"></param>
    /// <param name="environment"></param>
    public override void ConfigureApplication(WebApplication app, IWebHostEnvironment environment)
    {
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseAuthentication();
        app.UseRouting();

        app.UseAuthorization();

        app.MapRazorPages();

        app.Run();
    }
}

