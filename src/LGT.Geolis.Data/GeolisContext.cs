using Microsoft.EntityFrameworkCore;
namespace LGT.Geolis;
public class GeolisContext(DbContextOptions<GeolisContext> options): DbContext(options)
{
  #region Geoldba
  //Views
  public DbSet<Geoldba.Views.W_GSKL_LEID> W_GSKL_LEIDs => this.Set<Geoldba.Views.W_GSKL_LEID>();
  public DbSet<Geoldba.Views.W_ZGR_MARKSEID_PLANAI> W_ZGR_MARKSEID_PLANAIs => this.Set<Geoldba.Views.W_ZGR_MARKSEID_PLANAI>();
  public DbSet<Geoldba.Views.GG_ISTEKLIU_PLOTAI> GG_ISTEKLIU_PLOTAIs => this.Set<Geoldba.Views.GG_ISTEKLIU_PLOTAI>();
  //Tables
  public DbSet<Geoldba.GIS_ISTEKLIU_PLOTAI> IstekliuPlotai => this.Set< Geoldba.GIS_ISTEKLIU_PLOTAI>();
  public DbSet<Geoldba.Asmuo> Asmenys => this.Set<Geoldba.Asmuo>();
  public DbSet<Geoldba.JuridinisAsmuo> JuridiniaiAsmenys => this.Set<Geoldba.JuridinisAsmuo>();
  public DbSet<Geoldba.JungtinesVeiklosSutartis> JungtinesVeiklosSutartys => this.Set<Geoldba.JungtinesVeiklosSutartis>();

  public DbSet<Geoldba.Grezinys> Greziniai => this.Set<Geoldba.Grezinys>();

  public DbSet<Geoldba.IstekliuRusis> IštekliųRusys => this.Set<Geoldba.IstekliuRusis>();
  public DbSet<Geoldba.Isteklis> Istekliai => this.Set<Geoldba.Isteklis>();
  public DbSet<Geoldba.GavybosSklypas> GavybosSklypai => this.Set<Geoldba.GavybosSklypas>();
  public DbSet<Geoldba.Telkinys> Telkiniai => this.Set<Geoldba.Telkinys>();
  public DbSet<Geoldba.TelkinioSluoksnis> TelkinioSluoksniai => this.Set<Geoldba.TelkinioSluoksnis>();
  public DbSet<Geoldba.Leidimas> Leidimai => this.Set<Geoldba.Leidimas>();
  public DbSet<Geoldba.Sutartis> Sutartys => this.Set<Geoldba.Sutartis>();
  public DbSet<Geoldba.ZGRLGavybosObjektas> ZGRLGavybosObjektai => this.Set<Geoldba.ZGRLGavybosObjektas>();
  public DbSet<Geoldba.NER_GAV_KETV> NER_GAV_KETV => this.Set<Geoldba.NER_GAV_KETV>();

  #endregion
  #region INV
  public DbSet<INV.DarboVieta> DarboVietos => this.Set<INV.DarboVieta>();
  public DbSet<INV.Iranga> Inventorius => this.Set<INV.Iranga>();
  public DbSet<INV.InventoriausVieta> InventoriausVieta => this.Set< INV.InventoriausVieta>();
  #endregion
  //public DbSet<INV.INV> INVs { get; set; }
  protected override void OnModelCreating(ModelBuilder mb)
  {
    base.OnModelCreating(mb);
    mb.Entity<XY<Int64>>(xys => {
      xys.ToSqlQuery($"select TSO_ID \"Id\",  (TSO_OBJEKTAS).sdo_point.x X, (TSO_OBJEKTAS).sdo_point.y Y from GEOLDBA.GIS_TELKINIU_SCHEMU_EOBJ");
    });
    mb.Entity<Geolis.Geoldba.TelkinioSluoksnioTyrimas>().HasKey(item => new { item.TelkinioSluoksnisID, item.TyrimuRusisID, item.Metai, item.JuridinisAsmuoID });
    mb.Entity<Geolis.Geoldba.Telkinys_Tyrimas>().HasKey(item => new { item.TelkinysID, item.TyrimasID, item.At, item.JuridinisAsmuoID });
    // Relations
    mb.Entity<Geolis.INV.InventoriausVieta>().HasOne(item => item.Iranga)
      .WithOne(item => item.Vieta)
      .HasForeignKey<Geolis.INV.InventoriausVieta>(item => item.ID);
    // Oracle:
    mb.Model.SetMaxIdentifierLength(30); // Fixes ORA-00972 // https://stackoverflow.com/questions/62275227/ora-00972-identifier-is-too-long-error-with-ef-Geolis-2-2-code-first-migration
    // HasKey
    mb.Entity<Geolis.Geoldba.IstekliuPanaudojimas>().HasKey(item => new { item.TelkinysID, item.TelkinioSluoksnisID, item.PanaudojimoSritisID });
    mb.Entity<Geolis.Geoldba.TelkinioIstekliuPanaudojimas>().HasKey(item => new { item.TelkinysID, item.PanaudojimoSritisID });
    mb.Entity<Geolis.Geoldba.SutartiesSalyga>().HasKey(item => new { item.SutartisID, item.SutartisIndex });
    mb.Entity<Geolis.Geoldba.GR_KAD_KNYGOS>().HasKey(item => new { item.ID, item.PaketasID });
    mb.Entity<Geolis.Geoldba.NER_GAV_KETV>().HasKey(item => new { item.GavybosSklypasID, item.TelkinioSluoksnisID, item.GAVK_METAI, item.GAVK_KETV });
    // HasAlternateKey
    // Relations
    mb.Entity<Geolis.Geoldba.JuridinisAsmuo>().HasMany(item => item.Leidimai).WithOne(item => item.Kam_JuridinisAsmuo);

    // Fake keys: // TODO: ???
    mb.Entity<Geolis.Geoldba.GAVSKL_ISTEKLIAI>().HasKey(item => new { item.GavybosSklypasID, item.IstekliuRusisID, item.GSI_IST_DATA });

    mb.Entity<Geolis.Geoldba.TELK_AKTYV_LIKUTIS>().HasKey(item => new {
      item.TelkinysID,
      item.GavybosSklypasID,
      item.IstekliuRusisID,
      item.LIKA_LIK_METAI,
      item.LIKA_FAKT_DATA // todo:remove row, kai ištaisys klaidą Simonas (jei ne klaida - pašalinti komentarą)
    });

    mb.Entity<Geolis.Geoldba.GIS_TELKINIU_SCHEMU_EOBJ>(eobjs => {
      eobjs.HasOne(item => item.XY).WithMany()
        .HasForeignKey(item => item.Id).HasPrincipalKey(item => item.Id)
      ;
    });

    mb.Entity<Geolis.Geoldba.NER_ISK_GAV>().HasKey(item => new { item.GavybosSklypasID, item.TelkinioSluoksnisID, item.Metai });

    mb.Entity<Geolis.Geoldba.NER_GAV_KETV>().HasOne(item => item.Apjungejas).WithMany(item => item.Apjungtieji)
      .HasPrincipalKey(item => new { item.Metai, item.GavybosSklypasID, item.TelkinioSluoksnisID })
      .HasForeignKey(item => new { item.GAVK_METAI, item.GavybosSklypasID, item.TelkinioSluoksnisID })
    ;
    mb.Entity<Geolis.Geoldba.NER_GAV_1999>().HasKey(item => new { item.TelkinysID, item.TelkinioSluoksnisID });
    mb.Entity<Geolis.Geoldba.TEL_PRI_DOK>().HasKey(item => new { item.TelkinysID, item.J_DOKUMENTAIID });
  }
}
