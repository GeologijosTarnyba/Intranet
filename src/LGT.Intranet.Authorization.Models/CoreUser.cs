using Microsoft.AspNetCore.Identity;

namespace LGT.Intranet.Authorization.Models;
public class CoreUser : IdentityUser<int>
{
  public ICollection<IdentityUserClaim<int>>? ClaimValues { get; set; }
}
