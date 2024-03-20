using System.Runtime.CompilerServices;

namespace LGT.Geolis.Geoldba;
[Table(name: "GIS_ISTEKLIU_PLOTAI", Schema = "GEOLDBA")]
public class GIS_ISTEKLIU_PLOTAI
{
  [Key]
  [Column("IPL_ID")] public int ID { get; set; }

  [Required] public GG_GRAFIKOS_TIPAI? GrafikosTipas { get; set; }
  [Column("IPL_TGT_TRUMP")] public string GrafikosTipasId { get; set; } = default!;

	[Required] public TelkinioSluoksnis? TelkinioSluoksnis { get; set; }
  [Column("IPL_AGS_SL_NR")] public int? TelkinioSluoksnisID { get; set; }  // Unikalus, automati?kai generuojamas kodas.

  [Required] public Telkinys? Telkinys { get; set; }
  [Column("IPL_TELK_KODAS")] public int TelkinysID { get; set; }  // Unikalus, aut. gen. kodas, skirtas ry?iui su grafika.

  [Column("IPL_DATA_NUO")] public DateTime IPL_DATA_NUO { get; set; }
  [Column("IPL_DATA_IKI")] public DateTime? IPL_DATA_IKI { get; set; }

  [Required] public GG_MASTELIAI? Mastelis { get; set; }
  [Column("IPL_MAST_TRUMP")] public Int64 MastelisID { get; set; }

  [Column("IPL_ISTK_KATEGORIJA")] public string? IstekliuKategorijaID { get; set; }
  public IstekliuKategorija? IstekliuKategorija { get; set; }
}
