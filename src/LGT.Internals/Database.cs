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
    #region ToTables
    string incidentai = "I_";
    mb.Entity<Incidentas>().ToTable($"{incidentai}{nameof(Incidentas)}");
    mb.Entity<AptarnaujantiImone>().ToTable($"{incidentai}{nameof(AptarnaujantiImone)}");
    mb.Entity<AptarnavimoSutartis>().ToTable($"{incidentai}{nameof(AptarnavimoSutartis)}");
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
    
    mb.Entity<Darbuotojas>().Property(item => item.CreatedAt).HasDefaultValueSql(SQL_DT_NOW).IsRequired();
    mb.Entity<Skundas>().Property(item => item.CreatedAt).HasDefaultValueSql(SQL_DT_NOW).IsRequired();
    mb.Entity<Kreipinys>().Property(item => item.CreatedAt).HasDefaultValueSql(SQL_DT_NOW).IsRequired();
    mb.Entity<Sprendimas>().Property(item => item.CreatedAt).HasDefaultValueSql(SQL_DT_NOW).IsRequired();
    mb.Entity<Incidentas>().Property(item => item.CreatedAt).HasDefaultValueSql(SQL_DT_NOW).IsRequired();
    mb.Entity<AptarnavimoSutartis>().Property(item => item.CreatedAt).HasDefaultValueSql(SQL_DT_NOW).IsRequired();
  }
}
