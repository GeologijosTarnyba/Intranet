using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;

namespace LGT.Web.Authorization;
public class FlexibleAuthorizationPolicyProvider : DefaultAuthorizationPolicyProvider
{
  private readonly AuthorizationOptions _options;
  public FlexibleAuthorizationPolicyProvider(IOptions<AuthorizationOptions> options)
      : base(options)
  {
    _options = options.Value;
  }

  public override async Task<AuthorizationPolicy?> GetPolicyAsync(string policyName)
  {
    var policy = await base.GetPolicyAsync(policyName);
    // Jei toks policy dar neegzistuoja - sukuriamas naujas.
    if (policy == null)
    {
      if (IntranetPolicy.IsValidPolicyName(policyName))
      {
        var permissions = IntranetPolicy.GetPermissionsFrom(policyName);
        policy = new AuthorizationPolicyBuilder()
          .AddRequirements(new PermissionAuthorizationRequirement(permissions))
          .Build();
        _options.AddPolicy(policyName!, policy);
      }
      else if (AuthPolicy.IsValidPolicyName(policyName))
      {
        var permissions = AuthPolicy.GetPermissionsFrom(policyName);
        policy = new AuthorizationPolicyBuilder()
          .AddRequirements(new PermissionAuthorizationRequirement(permissions))
          .Build();
        _options.AddPolicy(policyName!, policy);
      } else if (GISPolicy.IsValidPolicyName(policyName))
      {
        var permissions = GISPolicy.GetPermissionsFrom(policyName);
        policy = new AuthorizationPolicyBuilder()
          .AddRequirements(new PermissionAuthorizationRequirement(permissions))
          .Build();
        _options.AddPolicy(policyName!, policy);
      }
    }
    return policy;
  }
}
