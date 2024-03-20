using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;

namespace LGT.Intranet.Authorization;
/// <summary>
/// Sukurtas pagal https://www.youtube.com/watch?v=BVJVhceN3N4, https://github.com/jasontaylordev/flexible-aspnetcore-authorization,
/// skiriasi tai, kad naudojami 3 enum tipai, ne vienas.
/// </summary>
public class FlexibleAuthorizationPolicyProvider(IOptions<AuthorizationOptions> options) : DefaultAuthorizationPolicyProvider(options)
{
  private readonly AuthorizationOptions _options = options.Value;
  public override async Task<AuthorizationPolicy?> GetPolicyAsync(string policyName)
  {
    var policy = await base.GetPolicyAsync(policyName);
    if (policy != null)
      return policy;
    // Jei toks policy dar neegzistuoja - sukuriamas naujas.
    if (IntranetPolicy.IsValidPolicyName(policyName))
    {
      var permissions = IntranetPolicy.GetPermissionsFrom(policyName);
      policy = new AuthorizationPolicyBuilder()
        .AddRequirements(new PermissionAuthorizationRequirement(permissions))
        .Build();
      _options.AddPolicy(policyName!, policy);
    }
    else if (AdministrationPolicy.IsValidPolicyName(policyName))
    {
      var permissions = AdministrationPolicy.GetPermissionsFrom(policyName);
      policy = new AuthorizationPolicyBuilder()
        .AddRequirements(new PermissionAuthorizationRequirement(permissions))
        .Build();
      _options.AddPolicy(policyName!, policy);
    }
    else if (GISPolicy.IsValidPolicyName(policyName))
    {
      var permissions = GISPolicy.GetPermissionsFrom(policyName);
      policy = new AuthorizationPolicyBuilder()
        .AddRequirements(new PermissionAuthorizationRequirement(permissions))
        .Build();
      _options.AddPolicy(policyName!, policy);
    } else
    {
      throw new Exception($"Invalid policy name \"{policyName}\".");
    }
    return policy;
  }
}
