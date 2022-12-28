namespace LGT.Core.Geoldba;
[Table(name: "TELK_AKTYV_LIKUTIS", Schema = "GEOLDBA")]
public class TELK_AKTYV_LIKUTIS
{
  public Telkinys Telkinys { get; set; }
  [Column("LIKA_TELK_KODAS")] public int TelkinysID { get; set; }
  public GavybosSklypas GavybosSklypas { get; set; } [Column("LIKA_GSKL_KODAS")] public int GavybosSklypasID { get; set; }
  public IstekliuRusis IstekliuRusis { get; set; }
  [Column("LIKA_IST_TRUMP")] public string IstekliuRusisID { get; set; }
  [Column("LIKA_GSKL_IST_DATA")] public DateTime? LIKA_GSKL_IST_DATA { get; set; } 
  [Column("LIKA_FAKT_DATA")] public DateTime? LIKA_FAKT_DATA { get; set; } 
  [Column("LIKA_GSKL_DATA_NUO")] public DateTime? LIKA_GSKL_DATA_NUO { get; set; } 
  [Column("LIKA_GSKL_DATA_IKI")] public DateTime? LIKA_GSKL_DATA_IKI { get; set; } 
  [Column("LIKA_GSKL_IST_KIEKIS")] public decimal? LIKA_GSKL_IST_KIEKIS { get; set; } 
  [Column("LIKA_GSKL_IST_KIEKIS_T")] public decimal? LIKA_GSKL_IST_KIEKIS_T { get; set; } 
  [Column("LIKA_LIK_METAI")] public int LIKA_LIK_METAI { get; set; } 
  [Column("LIKA_GSKL_LIK_KIEKIS")] public decimal? LIKA_GSKL_LIK_KIEKIS { get; set; } 
  [Column("LIKA_GSKL_LIK_KIEKIS_T")] public decimal? LIKA_GSKL_LIK_KIEKIS_T { get; set; } 
  [Column("LIKA_AU_DATA")] public DateTime? LIKA_AU_DATA { get; set; } 
  [Column("LIKA_AU_VARTOTOJAS")] public string LIKA_AU_VARTOTOJAS { get; set; } 
}
