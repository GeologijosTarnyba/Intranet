using Microsoft.EntityFrameworkCore;

namespace LGT.Kontaktai.Data;

public class KontaktaiContext(DbContextOptions<KontaktaiContext> options): DbContext(options)
{



  protected override void OnModelCreating(ModelBuilder mb) {
    base.OnModelCreating(mb);
  }
}
