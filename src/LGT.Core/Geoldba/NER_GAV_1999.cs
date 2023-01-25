namespace LGT.Core.Geoldba;
[Table(name: "NER_GAV_1999", Schema = "GEOLDBA")]
public class NER_GAV_1999
{
  public Telkinys Telkinys { get; set; }
  [Column("NG_TELK_KODAS")] public int TelkinysID { get; set; }
  public TelkinioSluoksnis TelkinioSluoksnis { get; set; }
  [Column("NG_AGS_SL_NR")] public int TelkinioSluoksnisID { get; set; }
  [Column("NG_MVN")] public string MatavimoVienetai { get; set; } 
  [Column("NG_KIEKIS")] public decimal? Kiekis { get; set; } 
  //[Column("NG_KIEKIS_TAME_TARPE")] public decimal? NG_KIEKIS_TAME_TARPE { get; set; } 
  //[Column("NG_KIEKIS_T")] public decimal? NG_KIEKIS_T { get; set; } 
  //[Column("NG_KIEKIS_TAME_TARPE_T")] public decimal? NG_KIEKIS_TAME_TARPE_T { get; set; } 
  //[Column("NG_KOEF_TM")] public decimal? NG_KOEF_TM { get; set; } 
  //[Column("NG_KOEF_TT_TM")] public decimal? NG_KOEF_TT_TM { get; set; } 
}