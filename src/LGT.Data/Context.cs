using Microsoft.EntityFrameworkCore;
namespace LGT.Data;
public class Context : DbContext
{
  //Views
  public DbSet<Core.Geoldba.Views.W_GSKL_LEID> W_GSKL_LEIDs { get; set; }
  public DbSet<Core.Geoldba.Views.W_ZGR_MARKSEID_PLANAI> W_ZGR_MARKSEID_PLANAIs { get; set; }
  public DbSet<Core.Geoldba.Views.GG_ISTEKLIU_PLOTAI> GG_ISTEKLIU_PLOTAIs { get; set; }
  //Tables
  public DbSet<Core.Geoldba.GIS_ISTEKLIU_PLOTAI> IstekliuPlotai { get; set; }
  public DbSet<Core.Geoldba.Asmuo> Asmenys { get; set; }
  public DbSet<Core.Geoldba.JuridinisAsmuo> JuridiniaiAsmenys { get; set; }
  public DbSet<Core.Geoldba.JungtinesVeiklosSutartis> JungtinesVeiklosSutartys { get; set; }

  public DbSet<Core.Geoldba.Grezinys> Greziniai { get; set; }

  public DbSet<Core.Geoldba.IstekliuRusis> IštekliųRusys { get; set; }
  public DbSet<Core.Geoldba.GavybosSklypas> GavybosSklypai { get; set; }
  public DbSet<Core.Geoldba.Telkinys> Telkiniai { get; set; }
  public DbSet<Core.Geoldba.TelkinioSluoksnis> TelkinioSluoksniai { get; set; }
  public DbSet<Core.Geoldba.Leidimas> Leidimai { get; set; }
  public DbSet<Core.Geoldba.Sutartis> Sutartys { get; set; }
  public DbSet<Core.Geoldba.ZGRLGavybosObjektas> ZGRLGavybosObjektai { get; set; }
  public DbSet<Core.Geoldba.NER_GAV_KETV> NER_GAV_KETV {  get; set; }
  #region INV
  public DbSet<Core.Inv.DarboVieta> DarboVietos { get; set; }
  #endregion
  //public DbSet<Inv.Inv> Invs { get; set; }

  #region Constructors
  public Context() : base() { }
  public Context(DbContextOptions options) : base(options)
  {
  }
  #endregion
  protected override void OnModelCreating(ModelBuilder mb)
  {
    base.OnModelCreating(mb);
    mb.Entity<Core.Geoldba.TelkinioSluoksnioTyrimas>().HasKey(item => new { item.TelkinioSluoksnisID, item.TyrimuRusisID, item.Metai, item.JuridinisAsmuoID });
    mb.Entity<Core.Geoldba.Telkinys_Tyrimas>().HasKey(item => new { item.TelkinysID, item.TyrimasID, item.At, item.JuridinisAsmuoID });
    // Relations
    mb.Entity<Core.Inv.InventoriausVieta>().HasOne(item => item.Iranga)
      .WithOne(item => item.Vieta)
      .HasForeignKey<Core.Inv.InventoriausVieta>(item => item.ID);
    // Oracle:
    mb.Model.SetMaxIdentifierLength(30); // Fixes ORA-00972 // https://stackoverflow.com/questions/62275227/ora-00972-identifier-is-too-long-error-with-ef-core-2-2-code-first-migration
    // HasKey
    mb.Entity<Core.Geoldba.IstekliuPanaudojimas>().HasKey(item => new { item.TelkinysID, item.TelkinioSluoksnisID, item.PanaudojimoSritisID });
    mb.Entity<Core.Geoldba.TelkinioIstekliuPanaudojimas>().HasKey(item => new { item.TelkinysID, item.PanaudojimoSritisID });
    mb.Entity<Core.Geoldba.SutartiesSalyga>().HasKey(item => new { item.SutartisID, item.SutartisIndex });
    mb.Entity<Core.Geoldba.GR_KAD_KNYGOS>().HasKey(item => new {item.ID, item.PaketasID });
    mb.Entity<Core.Geoldba.NER_GAV_KETV>().HasKey(item => new { item.GavybosSklypasID, item.TelkinioSluoksnisID, item.GAVK_METAI, item.GAVK_KETV });
    // HasAlternateKey
    // Relations
    mb.Entity<Core.Geoldba.JuridinisAsmuo>().HasMany(item => item.Leidimai).WithOne(item => item.Kam_JuridinisAsmuo);
  }
}