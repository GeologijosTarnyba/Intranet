using LGT.Intranet.Authorization;
using LGT.Intranet.Authorization.Models;
using LGT.Intranet.Components;
using LGT.Intranet.Components.Account;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LGT.Intranet;
public class Program
{
  public static void Main(string[] args)
  {
    string intranetContentRoot = Environment.GetEnvironmentVariable("dataFolder")
      ?? throw new Exception("Failed to read dataFolder ENVVAR");
    // https://learn.microsoft.com/en-us/aspnet/core/host-and-deploy/windows-service?view=aspnetcore-6.0&tabs=visual-studio
    var options = new WebApplicationOptions {
      Args = args,
      ContentRootPath = intranetContentRoot
      //ContentRootPath = Microsoft.Extensions.Hosting.WindowsServices.WindowsServiceHelpers.IsWindowsService() ? AppContext.BaseDirectory : default
    };
    var builder = WebApplication.CreateBuilder(options);

    // Add services to the container.
    builder.Services.AddRazorComponents()
        .AddInteractiveServerComponents();

    // Auth
    builder.Services.AddScoped<IdentityUserAccessor>();
    builder.Services.AddCascadingAuthenticationState();
    builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();
    builder.Services.AddSingleton<IAuthorizationPolicyProvider, FlexibleAuthorizationPolicyProvider>();
    builder.Services.AddSingleton<IAuthorizationHandler, PermissionAuthorizationHandler>();
    builder.Services.AddScoped<IdentityRedirectManager>();
    builder.Services.AddAuthentication(options => {
      options.DefaultScheme = IdentityConstants.ApplicationScheme;
      options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
      .AddIdentityCookies();
    builder.Services.AddIdentityCore<CoreUser>(options => {
      options.SignIn.RequireConfirmedAccount = false;
    })
      .AddEntityFrameworkStores<AuthorizationContext>()
      .AddSignInManager()
      .AddDefaultTokenProviders();



    
    string dbsFolder = Environment.GetEnvironmentVariable("dbsFolder") 
      ?? throw new Exception("Failed to read dbsFolder ENVVAR");
    if (!dbsFolder.EndsWith("/"))
    {
      dbsFolder = dbsFolder + "/";
    }

    builder.Services.AddDbContext<LGT.Intranet.Authorization.AuthorizationContext>(options => options.UseSqlite($"Data Source={dbsFolder}Intranet-Auth.db3", b => b.MigrationsAssembly($"LGT.Intranet")));
    builder.Services.AddDbContext<LGT.Intranet.IntranetContext>(options => options.UseSqlite($"Data Source={dbsFolder}Intranet.db3", b => b.MigrationsAssembly($"LGT.Intranet")));
    builder.Services.AddDbContext<LGT.Intranet.Internal.InternalContext>(options => options.UseSqlite($"Data Source={dbsFolder}Internal.db3", b => b.MigrationsAssembly($"LGT.Intranet")));
    
    string? geolisUser = Environment.GetEnvironmentVariable("geolisUser");
    string? geolisUserPassword = Environment.GetEnvironmentVariable("geolisUserPassword");
    if(geolisUser != null && geolisUserPassword != null)
    {
      builder.Services.AddDbContext<Geolis.GeolisContext>(ob => ob.UseOracle($"User Id={geolisUser};Password={geolisUserPassword}; Data Source=geolis2:1521/geolis2", b => b.MigrationsAssembly("LGT.Intranet")));
    }

    builder.Services.AddDatabaseDeveloperPageExceptionFilter();

    

    builder.Services.AddSingleton<IEmailSender<CoreUser>, IdentityNoOpEmailSender>();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
      app.UseMigrationsEndPoint();
    }
    else
    {
      app.UseExceptionHandler("/Error");
    }

    app.UseStaticFiles();
    app.UseAntiforgery();

    app.MapRazorComponents<App>()
        .AddInteractiveServerRenderMode();

    // Add additional endpoints required by the Identity /Account Razor components.
    app.MapAdditionalIdentityEndpoints();

    app.Run();
  }
}
