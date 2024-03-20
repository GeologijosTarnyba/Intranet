namespace LGT.Geolis.Geoldba;
[Table(name: "GIS_TELKINIO_SCHEMOS", Schema = "GEOLDBA")]
public class GIS_TELKINIO_SCHEMOS
{
  [Key]
  [Column("TSC_ID")] public int Id { get; set; }

  [Required] public GG_MASTELIAI? Mastelis { get; set; }
  [Column("TSC_MAST_TRUMP")] public Int64 MastelisId { get; set; } 

  [Required] public Telkinys? Telkinys { get; set; }
  [Column("TSC_TELK_KODAS")] public int TelkinysId { get; set; }  // Unikalus, aut. gen. kodas, skirtas ry?iui su grafika.

  [Required] public GIS_TELKINIU_SCHEMU_TIPAI? GIS_TELKINIU_SCHEMU_TIPAI { get; set; }
  [Column("TSC_TST_ID")] public int GIS_TELKINIU_SCHEMU_TIPAIID { get; set; } 
  
  //[Obsolete("DB aprašytas, bet nenaudojamas")] public GavybosSklypas? GavybosSklypas { get; set; } [Obsolete("DB aprašytas, bet nenaudojamas")][Column("TSC_GSKL_KODAS")] public int? GavybosSklypasId { get; set; }  // Unikalus aut. gener. kodas, skirtas ry?iui su grafiniu vaizdu.
  
  [Column("TSC_SCHEMOS_METAI")] public string TSC_SCHEMOS_METAI { get; set; } = default!;
	[Column("TSC_PATEIKIMO_DATA")] public DateOnly TSC_PATEIKIMO_DATA { get; set; }
  [Column("TSC_SCHEMOS_PAVADINIMAS")] public string? TSC_SCHEMOS_PAVADINIMAS { get; set; } 

  
  public ICollection<GIS_TELKINIU_SCHEMU_SLUOKSNIAI>? Sluoksniai { get; set; }
}
