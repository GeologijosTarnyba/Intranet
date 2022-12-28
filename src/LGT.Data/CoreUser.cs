using Microsoft.AspNetCore.Identity;
namespace LGT.Data;
public class CoreUser : IdentityUser<int>
{
  public ICollection<IdentityUserClaim<int>> ClaimValues { get; set; }
}
