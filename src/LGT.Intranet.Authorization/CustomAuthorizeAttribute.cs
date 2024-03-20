namespace LGT.Intranet.Authorization;

public class CustomAuthorizeAttribute : Microsoft.AspNetCore.Authorization.AuthorizeAttribute
{
  #region Constructors
  public CustomAuthorizeAttribute() { }
  public CustomAuthorizeAttribute(string policy) : base(policy) { }
  public CustomAuthorizeAttribute(AdminRights permissions) : this(AdministrationPolicy.GeneratePolicyNameFor(permissions))
  {
  }
  public CustomAuthorizeAttribute(IntranetRights permissions) : this(IntranetPolicy.GeneratePolicyNameFor(permissions))
  {
  }
  public CustomAuthorizeAttribute(GISRights permissions) : this(GISPolicy.GeneratePolicyNameFor(permissions))
  {
  }
  #endregion
}