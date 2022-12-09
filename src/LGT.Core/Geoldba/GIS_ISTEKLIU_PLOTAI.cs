namespace LGT.Core.Geoldba;
[Table(name: "GIS_ISTEKLIU_PLOTAI", Schema = "GEOLDBA")]
public class GIS_ISTEKLIU_PLOTAI
{
  [Key]
  [Column("IPL_ID")] public int ID { get; set; }
  [Column("IPL_TGT_TRUMP")] public string TelkinioSluoksnisID { get; set; } 
  public TelkinioSluoksnis TelkinioSluoksnis { get; set; }
  [Column("IPL_AGS_SL_NR")] public int? APIB_GEOL_SLID { get; set; }  // Unikalus, automati?kai generuojamas kodas.
  public Telkinys Telkinys { get; set; }
  [Column("IPL_TELK_KODAS")] public int TelkinysID { get; set; }  // Unikalus, aut. gen. kodas, skirtas ry?iui su grafika.
  [Column("IPL_DATA_NUO")] public DateTime IPL_DATA_NUO { get; set; }
  [Column("IPL_DATA_IKI")] public DateTime? IPL_DATA_IKI { get; set; }
  //[Column("IPL_MAST_TRUMP")] public Int64 IPL_MAST_TRUMP { get; set; } 
  [Column("IPL_ISTK_KATEGORIJA")] public string? IPL_ISTK_KATEGORIJA { get; set; } 
}