using LGT.Internals.Models.Incidents;
using LGT.Internals.Models.Kontaktai;
using Microsoft.EntityFrameworkCore;

namespace LGT.Internals;
public class Database : DbContext
{
  public DbSet<Incidentas> Incidentai => this.Set<Incidentas>();
  public DbSet<InformacinisIsteklius> InformaciniaiIstekliai => this.Set<InformacinisIsteklius>();
  #region Constructors
  public Database(DbContextOptions<Database> options) : base(options) { }
  private static readonly string SQL_DT_NOW = "datetime()";
  #endregion
  protected override void OnModelCreating(ModelBuilder mb)
  {
    base.OnModelCreating(mb);
    mb.Entity<Kreipinys>().HasKey(item => new {item.ID});
    #region ToTables
    string incidentai = "I_";
    mb.Entity<Incidentas>().ToTable($"{incidentai}{nameof(Incidentas)}");
    mb.Entity<AptarnaujantiImone>().ToTable($"{incidentai}{nameof(AptarnaujantiImone)}");
    mb.Entity<Kreipinys>().ToTable($"{incidentai}{nameof(Kreipinys)}");
    mb.Entity<Sprendimas>().ToTable($"{incidentai}{nameof(Sprendimas)}");
    mb.Entity<IncidentoPozymis>().ToTable($"{incidentai}{nameof(IncidentoPozymis)}");
    mb.Entity<InformacinisIsteklius>().ToTable($"{incidentai}{nameof(InformacinisIsteklius)}");
    mb.Entity<Skundas>().ToTable($"{incidentai}{nameof(Skundas)}");
    mb.Entity<SkundasType>().ToTable($"{incidentai}{nameof(SkundasType)}");
    string kontaktai = "K_";
    mb.Entity<Asmuo>().ToTable($"{kontaktai}{nameof(Asmuo)}");
    mb.Entity<Darboviete>().ToTable($"{kontaktai}{nameof(Darboviete)}");
    mb.Entity<Darbuotojas>().ToTable($"{kontaktai}{nameof(Darbuotojas)}");
    #endregion
    mb.Entity<Sprendimas>().HasOne(item => item.Kreipinys).WithMany(item => item.Sprendimai)
      .HasForeignKey(item => new {item.DarbovieteID, item.KreipinysID })
      .HasPrincipalKey(item => new { item.DarbovieteID, item.ID });
    mb.Entity<Sprendimas>().HasOne(item => item.Darbuotojas).WithMany(item => item.Sprendimai)
      .HasForeignKey(item => new { item.DarbovieteID, item.DarbuotojasID })
      .HasPrincipalKey(item => new {item.DarbovieteID, item.ID });
    mb.Entity<Skundas>().Property(item => item.CreatedAt).HasDefaultValueSql(SQL_DT_NOW);
    mb.Entity<Darbuotojas>().Property(item => item.CreatedAt).HasDefaultValueSql(SQL_DT_NOW);


    mb.Entity<Kreipinys>().Property(item => item.CreatedAt).HasDefaultValueSql(SQL_DT_NOW);
    mb.Entity<Sprendimas>().Property(item => item.CreatedAt).HasDefaultValueSql(SQL_DT_NOW);
    mb.Entity<Incidentas>().Property(item => item.CreatedAt).HasDefaultValueSql(SQL_DT_NOW);
  }
}
