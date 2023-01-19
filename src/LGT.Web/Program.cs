global using LGT.Web.Authorization;
global using LGT.Web.Shared;
using LGT.Web.Areas.Identity;
using LGT.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace LGT.Web;
public class Program
{
  public static void Main(string[] args)
  {
    // https://learn.microsoft.com/en-us/aspnet/core/host-and-deploy/windows-service?view=aspnetcore-6.0&tabs=visual-studio
    var options = new WebApplicationOptions
    {
      Args = args,
      ContentRootPath = Microsoft.Extensions.Hosting.WindowsServices.WindowsServiceHelpers.IsWindowsService()
        ? AppContext.BaseDirectory : default
    };
    var builder = WebApplication.CreateBuilder(options);
    string folder = get("minus_folder", errorMessage: "data folder unclean", "C:\\Data");

    builder.Services.AddDbContext<LGT.Internals.Database>(item => item.UseSqlite($"Data Source={folder}\\dbs\\Internals.db3", b => b.MigrationsAssembly("LGT.Web")));
    builder.Services.AddDbContext<LGT.Data.IntranetContext>(item => item.UseSqlite($"Data Source={folder}\\dbs\\Intranet.db3", b => b.MigrationsAssembly("LGT.Web")));
    var geolisUser = get("Geoldba:Database:UserName", errorMessage: "geolisUser"
      , defaultValue: null
    );
    var geolisUserPassword = get("Geoldba:Database:Password", errorMessage: "geolisUserPassword"
      , defaultValue: null
    );
    builder.Services.AddDbContext<Data.GeolisContext>(
      optionBuilder => optionBuilder.UseOracle($"User Id={geolisUser};Password={geolisUserPassword};Data Source=geolis2:1521/geolis2")
    );

    builder.Services.AddDatabaseDeveloperPageExceptionFilter();
    builder.Services.AddDefaultIdentity<CoreUser>(options => {
      options.SignIn.RequireConfirmedAccount = false;
    })
    .AddEntityFrameworkStores<IntranetContext>();
    
    builder.Services.AddAuthentication();
    builder.Services.AddRazorPages();
    builder.Services.AddServerSideBlazor();
    builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<CoreUser>>();
    builder.Services.AddSingleton<IAuthorizationPolicyProvider, FlexibleAuthorizationPolicyProvider>();
    builder.Services.AddSingleton<IAuthorizationHandler, PermissionAuthorizationHandler>();
    builder.Host.UseWindowsService();
    var app = builder.Build();
    if (app.Environment.IsDevelopment())
    {
      app.UseMigrationsEndPoint();
    }
    else
    {
      app.UseExceptionHandler("/Error");
      app.UseHsts();
    }
    app.UseHttpsRedirection();
    app.UseStaticFiles();
    app.UseRouting();
    app.UseAuthentication();
    app.UseAuthorization();
    app.MapControllers();
    app.MapBlazorHub();
    app.MapFallbackToPage("/_Host");

    app.Run();
  }
  private static string get(string name, string? errorMessage = null, string? defaultValue = null)
  {
    if (errorMessage == null && defaultValue == null)
      throw new Exception("errorMessage or default value is required.");
    return Environment.GetEnvironmentVariable(name)
      ?? defaultValue
      ?? throw new Exception($"Unclear {errorMessage} [{name}]")
    ;
  }
}
