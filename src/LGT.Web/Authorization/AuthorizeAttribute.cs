namespace LGT.Web.Authorization;

public class CustomAuthorizeAttribute : Microsoft.AspNetCore.Authorization.AuthorizeAttribute
{
  #region Constructors
  public CustomAuthorizeAttribute() { }
  public CustomAuthorizeAttribute(string policy) : base(policy) { }
  public CustomAuthorizeAttribute(IntranetEnum permission) : base(IntranetPolicy.GeneratePolicyNameFor(permission))
  {
  }
  public CustomAuthorizeAttribute(AdminRightsEnum permissions) : base(AuthPolicy.GeneratePolicyNameFor(permissions))
  {
  }
  public CustomAuthorizeAttribute(GISEnum permissions) : base(GISPolicy.GeneratePolicyNameFor(permissions))
  {
  }
  #endregion
}