using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.FluentUI.AspNetCore.Components;
using TastyEatsBD.Core.Entities;
using TastyEatsBD.Infrastructure.Data;
using TastyEatsBD.WebApp.Components;
using TastyEatsBD.WebApp.Services.Identity;

public class Startup
{
    private IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddProblemDetails();
        services.AddRazorComponents()
            .AddInteractiveServerComponents();

        services.AddCascadingAuthenticationState();
        services.AddScoped<IdentityUserAccessor>();
        services.AddScoped<IdentityRedirectManager>();
        services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

        services.AddAuthentication(options =>
        {
            options.DefaultScheme = IdentityConstants.ApplicationScheme;
            options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
        })
        .AddIdentityCookies();

        services.AddPooledDbContextFactory<TastyEatsDbContext>(options =>
        {
            options.UseSqlServer(Configuration.GetConnectionString("cnTastyEatsDb"));
        });
        services.AddDbContext<AppIdentityDbContext>(options =>
        {
            options.UseSqlServer(Configuration.GetConnectionString("cnAppIdentityDb"));
        });
        services.AddDatabaseDeveloperPageExceptionFilter();

        services.AddIdentityCore<AppIdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<AppIdentityDbContext>()
                .AddSignInManager()
                .AddDefaultTokenProviders();

        services.AddSingleton<IEmailSender<AppIdentityUser>, IdentityNoOpEmailSender>();

        services.AddHttpClient();
        services.AddFluentUIComponents();
        services.AddDataGridEntityFrameworkAdapter();

        services.AddHttpContextAccessor();

        services.AddApplicationServices();
    }

    public void Configure(WebApplication app, IWebHostEnvironment env)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseMigrationsEndPoint();
            ConfigureDatabase(app);
        }
        else
        {
            app.UseExceptionHandler("/Error", createScopeForErrors: true);
            app.UseHsts();
        }

        app.UseStaticFiles();

        app.UseAntiforgery();

        //app.UseOutputCache();

        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();

        app.MapDefaultEndpoints();

        // Add additional endpoints required by the Identity /Account Razor components.
        app.MapAdditionalIdentityEndpoints();

        //app.UseCustomMiddleware();
    }

    private void ConfigureDatabase(WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        var factory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<TastyEatsDbContext>>();

        using var eatsDbContext = factory.CreateDbContext();
        eatsDbContext.Database.EnsureCreated();

        var identityDbContext = scope.ServiceProvider.GetRequiredService<AppIdentityDbContext>();
        identityDbContext.Database.EnsureCreated();
    }
}