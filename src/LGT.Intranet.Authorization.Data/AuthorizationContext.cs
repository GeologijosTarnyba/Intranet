using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace LGT.Intranet.Authorization;
using LGT.Intranet.Authorization.Models;

public class AuthorizationContext(DbContextOptions<AuthorizationContext> options) : IdentityDbContext<CoreUser, IdentityRole<int>, int>(options)
{
  protected override void OnModelCreating(ModelBuilder mb)
  {
    base.OnModelCreating(mb);
    mb.Entity<IdentityUserClaim<int>>().HasAlternateKey(item => new { item.UserId, item.ClaimType });
    mb.Entity<CoreUser>().HasMany(item => item.ClaimValues).WithOne().HasForeignKey(item => item.UserId);
  }
}
