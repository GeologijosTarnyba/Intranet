using Microsoft.EntityFrameworkCore;

namespace LGT.Kontaktai;
public class KontaktaiContext(DbContextOptions<KontaktaiContext> options): DbContext(options)
{

  public IQueryable<Models.Darbuotojas> LGTDirbantysDarbuotojai => this.Set<Models.Darbuotojas>()
    .Where(item => item.DarbovieteId == "lgt")
    .Where(item => item.Until == null || item.Until >  DateTime.Now)
    .Where(item => item.Since == null || item.Since < DateTime.Now)
    ;
  private static readonly string SQL_DT_NOW = "datetime()";
  protected override void OnModelCreating(ModelBuilder mb)
  {
    mb.Entity<Models.Darboviete>(darbovietes => {
      darbovietes.ToTable($"Darbovietes");
      darbovietes.HasMany(item => item.Padaliniai).WithOne(item => item.Darboviete).OnDelete(DeleteBehavior.Restrict);
      darbovietes.HasMany(item => item.Etatai).WithOne(item => item.Darboviete).OnDelete(DeleteBehavior.Restrict);
    });
    mb.Entity<Models.Padalinys>(padaliniai => {
      padaliniai.ToTable($"Padaliniai");
      padaliniai.HasMany(item => item.Etatai).WithOne(item => item.Padalinys).OnDelete(DeleteBehavior.Restrict);
    });
    mb.Entity<Models.Etatas>(etatai => {
      etatai.ToTable($"Etatai");
      etatai.HasOne(item => item.Name).WithMany().OnDelete(DeleteBehavior.Restrict);
    });
    mb.Entity<Models.Darbuotojas>(darbuotojai => {
      darbuotojai.ToTable($"Darbuotojai");
    });
    mb.Entity<Models.EtatasName>(names => {
      names.ToTable($"EtatuPavadinimai");
    });


    mb.Entity<Models.Darbuotojas>().Property(item => item.CreatedAt).HasDefaultValueSql(SQL_DT_NOW).IsRequired();
    base.OnModelCreating(mb);
  }
}
