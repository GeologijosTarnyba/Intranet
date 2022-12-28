using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LGT.Data;
public class IntranetContext : IdentityDbContext<CoreUser, IdentityRole<int>, int>
{
  public DbSet<Core.Intranet.Page> Pages { get; set; }
  public DbSet<Core.Intranet.Column> Columns { get; set; }
  public DbSet<Core.Intranet.Group> Groups { get; set; }
  public DbSet<Core.Intranet.Link> Links { get; set; }
  public DbSet<Core.Intranet.Message> Messages { get; set; }
  public DbSet<Core.Intranet.Article> Articles { get; set; }
  #region Constructors
  public IntranetContext(DbContextOptions<IntranetContext> options)
      : base(options)
  {
  }
  #endregion
  protected override void OnModelCreating(ModelBuilder mb)
  {
    mb.Model.SetMaxIdentifierLength(30); // Fixes ORA-00972 // https://stackoverflow.com/questions/62275227/ora-00972-identifier-is-too-long-error-with-ef-core-2-2-code-first-migration
    base.OnModelCreating(mb);
    mb.Entity<IdentityUserClaim<int>>().HasAlternateKey(item => new { item.UserId, item.ClaimType });

    mb.Entity<CoreUser>().HasMany(item => item.ClaimValues).WithOne().HasForeignKey(item => item.UserId);
  }
}
