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
    var builder = WebApplication.CreateBuilder(args);

    var intranetDataSource = null ?? Environment.GetEnvironmentVariable("Intranet:Database:ConnectionString") ?? throw new Exception("Unclear ConnectionString [Intranet:Database:ConnectionString]");
    var intranetUser = null ?? Environment.GetEnvironmentVariable("Intranet:Database:UserName") ?? throw new Exception("Unclear IntranetUserName [Intranet:Database:UserName]");
    var intranetUserPassword = null ?? Environment.GetEnvironmentVariable("Intranet:Database:Password") ?? throw new Exception("Unclear IntranetUserPassword [Intranet:Database:Password]");
    builder.Services.AddDbContext<Data.IntranetContext>(
      optionsBuilder => optionsBuilder.UseOracle($"User Id={intranetUser};Password={intranetUserPassword};Data Source={intranetDataSource}",
      b => {
        b.MigrationsAssembly("LGT.Web");
        b.UseOracleSQLCompatibility("12");
      })
    );


    var geolisUser = (string?)null ?? Environment.GetEnvironmentVariable("Geoldba:Database:UserName") ?? throw new Exception("Unclear GeolisUserName [Geoldba:Database:UserName]");
    var geolisUserPassword = (string?)null ?? Environment.GetEnvironmentVariable("Geoldba:Database:Password") ?? throw new Exception("Unclear GeolisUserPassword [Geoldba:Database:Password]");
    builder.Services.AddDbContext<Data.GeolisContext>(
      optionBuilder => optionBuilder.UseOracle($"User Id={geolisUser};Password={geolisUserPassword};Data Source=geolis2:1521/geolis2")
    );

    builder.Services.AddDatabaseDeveloperPageExceptionFilter();
    builder.Services.AddDefaultIdentity<CoreUser>(options => {
      options.SignIn.RequireConfirmedAccount = false;
    })
    .AddEntityFrameworkStores<IntranetContext>();
    
    builder.Services
     .AddAuthentication()
    ;
    builder.Services.AddRazorPages();
    builder.Services.AddServerSideBlazor();
    builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<CoreUser>>();
    builder.Services.AddSingleton<IAuthorizationPolicyProvider, FlexibleAuthorizationPolicyProvider>();
    builder.Services.AddSingleton<IAuthorizationHandler, PermissionAuthorizationHandler>();
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
