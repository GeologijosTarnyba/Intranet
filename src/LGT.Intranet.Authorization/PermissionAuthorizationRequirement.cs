using Microsoft.AspNetCore.Authorization;
namespace LGT.Intranet.Authorization;
public class PermissionAuthorizationRequirement : IAuthorizationRequirement
{
  private string Prefix { get; }
  IntranetRights? Intranet { get; }
  AdminRights? Auth { get; }
  GISRights? GIS { get; }
  #region Constructors
  public PermissionAuthorizationRequirement(IntranetRights permission)
  {
    this.Intranet = permission;
    this.Prefix = IntranetPolicy.Prefix;
  }
  public PermissionAuthorizationRequirement(AdminRights permissions)
  {
    this.Auth = permissions;
    this.Prefix = AdministrationPolicy.Prefix;
  }
  public PermissionAuthorizationRequirement(GISRights permissions)
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
      var userPermissions = (IntranetRights)permissionClaimValue;
      if ((userPermissions & this.Intranet) != 0)
      {
        context.Succeed(this);
        return Task.CompletedTask;
      }
    } else if (this.Auth != null)
    {
      var userPermissions = (AdminRights)permissionClaimValue;
      if ((userPermissions & this.Auth) != 0)
      {
        context.Succeed(this);
        return Task.CompletedTask;
      }
    } else if (this.GIS != null)
    {
      var userPermissions = (GISRights)permissionClaimValue;
      if ((userPermissions & this.GIS) != 0)
      {
        context.Succeed(this);
        return Task.CompletedTask;
      }
    }
    return Task.CompletedTask;
  }
}
