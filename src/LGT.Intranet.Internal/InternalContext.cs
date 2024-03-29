using LGT.Incidentai.Models;
using LGT.Incidentai.Models.Kontaktai;
using Microsoft.EntityFrameworkCore;

namespace LGT.Intranet.Internal;
/// <summary>
/// Sudarytas iš dviejų pagrindinių dalių - Incindentų ir Kontaktų .
/// </summary>
/// <param name="options"></param>
public class InternalContext(DbContextOptions<InternalContext> options): DbContext(options)
{
  public DbSet<Incidentas> Incidentai => this.Set<Incidentas>();
  public DbSet<InformacinisIsteklius> InformaciniaiIstekliai => this.Set<InformacinisIsteklius>();

  private static readonly string SQL_DT_NOW = "datetime()";
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
    #endregion
    string kontaktai = "K_";
    mb.Entity<Asmuo>().ToTable($"{kontaktai}{nameof(Asmuo)}");
    mb.Entity<Darboviete>(darbovietes => {
      darbovietes.ToTable($"{kontaktai}Darboviete");
    });
    mb.Entity<Darbuotojas>(darbuotojai => {
      darbuotojai.ToTable($"{kontaktai}Darbuotojas");
    });
    // CreatedAt
    mb.Entity<Skundas>().Property(item => item.CreatedAt).HasDefaultValueSql(SQL_DT_NOW).IsRequired();
    mb.Entity<Kreipinys>().Property(item => item.CreatedAt).HasDefaultValueSql(SQL_DT_NOW).IsRequired();
    mb.Entity<Sprendimas>().Property(item => item.CreatedAt).HasDefaultValueSql(SQL_DT_NOW).IsRequired();
    mb.Entity<Incidentas>().Property(item => item.CreatedAt).HasDefaultValueSql(SQL_DT_NOW).IsRequired();
    mb.Entity<AptarnavimoSutartis>().Property(item => item.CreatedAt).HasDefaultValueSql(SQL_DT_NOW).IsRequired();
  }
}
