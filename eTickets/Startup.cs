using eTickets.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

                                                                                                                      // Register services to DI container
    public void ConfigureServices(IServiceCollection services)
    {
        // DbContext Confuguration
        services.AddDbContext<AddDbContext>(options => options.UseSqlServer
            (Configuration.GetConnectionString("DefaulConnectionStrings")));

        services.AddControllers();                                                                                   // or AddRazorPages(), AddEndpointsApiExplorer(), etc.
                                                                                                                     // Add other services here
    }

                                                                                                                     // Configure the HTTP request pipeline
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");                                                                             // or MapRazorPages(), MapDefaultControllerRoute(), etc.
        });
        //Seed database
        AddDbInitializer.Seed(app);
    }
}
