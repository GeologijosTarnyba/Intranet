global using LGT.Web.Authorization;
global using LGT.Web.Shared;
using LGT.Web.Areas.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using LGT.Web.Areas.Internals.Out;
using Microsoft.Extensions.Options;

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
        ? AppContext.BaseDirectory
        : default
    };
    var builder = WebApplication.CreateBuilder(options);
    string dataFolder = builder.Configuration["minus_folder"] ?? throw new Exception("Failed to get path to folder folder.");
    string geolisUser = builder.Configuration["Geoldba:Database:UserName"] ?? throw new Exception("Failed to get Geolis database username.");
    string geolisUserPassword = builder.Configuration["Geoldba:Database:Password"] ?? throw new Exception("Failed to get Geolis database user password.");

    builder.Services.AddDbContext<LGT.Internals.Database>(ob => ob.UseSqlite($"Data Source={dataFolder}\\dbs\\Internals.db3", b => b.MigrationsAssembly("LGT.Web")));
    builder.Services.AddDbContext<LGT.Data.IntranetContext>(ob => ob.UseSqlite($"Data Source={dataFolder}\\dbs\\Intranet.db3", b => b.MigrationsAssembly("LGT.Web")));
    builder.Services.AddDbContext<LGT.Data.GeolisContext>(ob => ob.UseOracle($"User Id={geolisUser};Password={geolisUserPassword}; Data Source=geolis2:1521/geolis2", b => b.MigrationsAssembly("LGT.Web")));
    builder.Services.AddDbContext<Incidentai.Data.Database>(ob => ob.UseOracle($"User Id={geolisUser};Password={geolisUserPassword}; Data Source=geolis2:1521/geolis2", b => b.MigrationsAssembly("LGT.Web")));

    builder.Services.AddDatabaseDeveloperPageExceptionFilter();
    // Auth
    //builder.Services.ConfigureApplicationCookie(cokies => { 

    //  });
    builder.Services.AddAuthentication(o =>
    {
      o.DefaultScheme = IdentityConstants.ApplicationScheme;
      o.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
        .AddCookie(o =>
        {
          o.ExpireTimeSpan = TimeSpan.FromDays(24);
        })
      .AddIdentityCookies(o => { });
    builder.Services.AddIdentityCore<LGT.Data.CoreUser>(o =>
    {
      o.Stores.MaxLengthForKeys = 128;
      o.SignIn.RequireConfirmedAccount = false;
    })
        .AddDefaultUI()
        .AddDefaultTokenProviders()
        .AddEntityFrameworkStores<LGT.Data.IntranetContext>()
     ;

    //builder.Services.AddDefaultIdentity<LGT.Data.CoreUser>(options => {
    //  options.SignIn.RequireConfirmedAccount = false;

    //})
    //.AddEntityFrameworkStores<LGT.Data.IntranetContext>();

    builder.Services.AddAuthentication();
    builder.Services.AddRazorPages();
    builder.Services.AddServerSideBlazor();
    builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<LGT.Data.CoreUser>>();
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
}
