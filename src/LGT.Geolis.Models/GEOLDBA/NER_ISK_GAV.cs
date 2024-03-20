namespace LGT.Geolis.Geoldba;
[Table(name: "NER_ISK_GAV", Schema = "GEOLDBA")]
public class NER_ISK_GAV
{

  public ICollection<NER_GAV_KETV>? Apjungtieji { get; set; }

  [Required] public GavybosSklypas? GavybosSklypas { get; set; }
  [Column("GAV_GSKL_KODAS")] public int GavybosSklypasID { get; set; }  // Unikalus aut. gener. kodas, skirtas ry?iui su grafiniu vaizdu.
  [Required] public TelkinioSluoksnis? TelkinioSluoksnis { get; set; }
  [Column("GAV_AGS_SL_NR")] public int TelkinioSluoksnisID { get; set; }
  [Required] public IstekliuRusis? IstekliuRusis { get; set; }
  [Column("GAV_IST_TRUMP")] public string? IstekliuRusisID { get; set; } 

  [Column("GAV_METAI")] public int Metai { get; set; }  // Gavybos metai.
  [Column("GAV_KIEKIS")] public decimal? GAV_KIEKIS { get; set; }  // I?gautas i?kasen? kiekis.
  [Column("GAV_NUOSTOLIS")] public decimal? GAV_NUOSTOLIS { get; set; }  // Gavybos nuostolis.
  [Column("GAV_REKULTIVUOTAS_PLOTAS")] public int? GAV_REKULTIVUOTAS_PLOTAS { get; set; }  // Rekultivuotas plotas, kvadr. metrais.
  [Column("GAV_UZ_KONT")] public decimal? GAV_UZ_KONT { get; set; } 
  [Column("GAV_KIEKIS_TAME_TARPE")] public decimal? GAV_KIEKIS_TAME_TARPE { get; set; } 
  [Column("GAV_KODAS")] public int? GAV_KODAS { get; set; }  // Pirminio rakto laukas. Generuojamas DB iterpiant nauja irasa.
  [Column("GAV_NUOSTOLIS_TAME_TARPE")] public decimal? GAV_NUOSTOLIS_TAME_TARPE { get; set; } 
  [Column("GAV_KIEKIS_T")] public decimal? GAV_KIEKIS_T { get; set; } 
  [Column("GAV_NUOSTOLIS_T")] public decimal? GAV_NUOSTOLIS_T { get; set; } 
  [Column("GAV_UZ_KONT_T")] public decimal? GAV_UZ_KONT_T { get; set; } 
  [Column("GAV_KIEKIS_TAME_TARPE_T")] public decimal? GAV_KIEKIS_TAME_TARPE_T { get; set; } 
  [Column("GAV_NUOSTOLIS_TAME_TARPE_T")] public decimal? GAV_NUOSTOLIS_TAME_TARPE_T { get; set; } 
  [Column("GAV_MVN")] public string? GAV_MVN { get; set; } 
  //[Column("GAV_KOEF_TM")] public decimal? GAV_KOEF_TM { get; set; } 
  //[Column("GAV_KOEF_TT_TM")] public decimal? GAV_KOEF_TT_TM { get; set; } 
  [Column("GAV_DOK_DATA")] public DateTime? GAV_DOK_DATA { get; set; }  // dokumentų (markšeiderinių planų) pateikimo data. Jei metuose buvo keli matavimai - paskutinio.
  /// <summary>
  /// GAVK_IST_PASIKEITIMAS laiko sumo ketvirtinėse
  /// </summary>
  [Column("GAV_NUOST_2015")] public decimal? GAV_NUOST_2015 { get; set; } 
  [Column("GAV_PASTABA")] public string? Comment { get; set; }
}
