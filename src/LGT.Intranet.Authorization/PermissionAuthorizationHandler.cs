using Microsoft.AspNetCore.Authorization;

namespace LGT.Intranet.Authorization;
public class PermissionAuthorizationHandler : AuthorizationHandler<PermissionAuthorizationRequirement>
{
  protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionAuthorizationRequirement requirement) 
    => requirement.Check(context);
}