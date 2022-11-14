using Microsoft.AspNetCore.Authorization;
namespace LGT.Web.Authorization;
public class PermissionAuthorizationRequirement : IAuthorizationRequirement
{
  private string Prefix { get; }
  IntranetEnum? Intranet { get; }
  AdminRightsEnum? Auth { get; }
  GISEnum? GIS { get; }
  #region Constructors
  public PermissionAuthorizationRequirement(IntranetEnum permission)
  {
    this.Intranet = permission;
    this.Prefix = IntranetPolicy.Prefix;
  }
  public PermissionAuthorizationRequirement(AdminRightsEnum permissions)
  {
    this.Auth = permissions;
    this.Prefix = AuthPolicy.Prefix;
  }
  public PermissionAuthorizationRequirement(GISEnum permissions)
  {
    this.GIS = permissions;
    this.Prefix = GISPolicy.Prefix;
  }
  #endregion
  public Task Check(AuthorizationHandlerContext context)
  {
    var permissionClaim = context.User.FindFirst(c => c.Type == this.Prefix);
    if (permissionClaim == null)
      return Task.CompletedTask;
    if (!Int64.TryParse(permissionClaim.Value, out Int64 permissionClaimValue))
      return Task.CompletedTask;

    
    if (this.Intranet != null)
    {
      var userPermissions = (IntranetEnum)permissionClaimValue;
      if ((userPermissions & this.Intranet) != 0)
      {
        context.Succeed(this);
        return Task.CompletedTask;
      }
    } else if (this.Auth != null)
    {
      var userPermissions = (AdminRightsEnum)permissionClaimValue;
      if ((userPermissions & this.Auth) != 0)
      {
        context.Succeed(this);
        return Task.CompletedTask;
      }
    } else if (this.GIS != null)
    {
      var userPermissions = (GISEnum)permissionClaimValue;
      if ((userPermissions & this.GIS) != 0)
      {
        context.Succeed(this);
        return Task.CompletedTask;
      }
    }
    return Task.CompletedTask;
  }
}
public class PermissionAuthorizationHandler : AuthorizationHandler<PermissionAuthorizationRequirement>
{
  protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionAuthorizationRequirement requirement)
  {
    return requirement.Check(context);
  }
}