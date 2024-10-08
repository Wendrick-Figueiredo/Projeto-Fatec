using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore; // Importante para DbContext
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}
public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<SeuDbContext>(options =>
        options.UseNpgsql(Configuration.GetConnectionString("SeuDbContext")));

        // Adiciona serviços de autorização
        services.AddAuthorization();

        // Outros serviços
        services.AddControllersWithViews(); // ou services.AddRazorPages(); dependendo do seu projeto
    }

    public void Configures(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Configuração do pipeline de middleware
    }

    public static void Main(string[] args)
    => CreateHostBuilder(args).Build().Run();

    // EF Core uses this method at design time to access the DbContext
    public static IHostBuilder CreateHostBuilder(string[] args)
        => Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(
                webBuilder => webBuilder.UseStartup<Startup>());

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        // Middleware de autorização
        app.UseAuthentication(); // Se estiver usando autenticação
        app.UseAuthorization();   // Certifique-se de que está aqui

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=login}/{id?}");
        });
    }
}