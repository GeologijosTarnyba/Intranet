using LGT.Intranet.Authorization.Models;
using Microsoft.AspNetCore.Identity;

namespace LGT.Intranet.Components.Account;
internal sealed class IdentityUserAccessor(UserManager<CoreUser> userManager, IdentityRedirectManager redirectManager)
{
  public async Task<CoreUser> GetRequiredUserAsync(HttpContext context)
  {
    var user = await userManager.GetUserAsync(context.User);

    if (user is null)
    {
      redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
    }

    return user;
  }
}
