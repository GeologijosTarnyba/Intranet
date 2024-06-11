using LGT.Internal.DovanuDeklaravimas.Models;
using Microsoft.EntityFrameworkCore;

namespace LGT.Internal.DovanuDeklaravimas;
public class Database(DbContextOptions<Database> options): DbContext(options)
{
  public DbSet<Gift> Gifts => this.Set<Gift>();

  protected override void OnModelCreating(ModelBuilder mb)
  {
    base.OnModelCreating(mb);
    mb.Entity<GiftStatus>(table => {
      table.Property(item => item.CreatedAt).HasDefaultValueSql("datetime('now')");
    });
  }
}
