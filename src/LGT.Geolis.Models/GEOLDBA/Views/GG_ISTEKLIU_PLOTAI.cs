namespace LGT.Geolis.Geoldba.Views;
[Table(name: "GG_ISTEKLIU_PLOTAI", Schema = "GEOLDBA")]
public class GG_ISTEKLIU_PLOTAI
{
  [Column("IPL_ID")] public int ID { get; set; } 
  [Column("AGS_SL_NR")] public string? AGS_SL_NR { get; set; } 
  [Column("AGS_PAVADINIMAS")] public string? AGS_PAVADINIMAS { get; set; } 
  [Column("TELK_KODAS")] public int TELK_KODAS { get; set; } 
  [Column("TELK_PAVADINIMAS")] public string TELK_PAVADINIMAS { get; set; } = default!;
  [Column("TELK_ANTRAS_PAV")] public string? TELK_ANTRAS_PAV { get; set; } 
  [Column("TELK_NUMERIS")] public string? TELK_NUMERIS { get; set; } 
  [Column("TELK_IST_TRUMP")] public string TELK_IST_TRUMP { get; set; } = default!;
  [Column("NAUDINGOJI_ISKASENA")] public string? NAUDINGOJI_ISKASENA { get; set; } 
  [Column("GRAFIKA_TRUMP")] public string GRAFIKA_TRUMP { get; set; } = default!;
  [Column("ISTEKLIU_GRUPE")] public string ISTEKLIU_GRUPE { get; set; } = default!;
  [Column("ISTEKLIU_RUSIS")] public string ISTEKLIU_RUSIS { get; set; } = default!;
  [Column("DATA_NUO")] public DateTime DATA_NUO { get; set; } 
  [Column("DATA_IKI")] public DateTime? DATA_IKI { get; set; } 
  [Column("MASTELIS")] public int MASTELIS { get; set; } 
  [Column("ISTEKLIU_KATEGORIJA")] public string? ISTEKLIU_KATEGORIJA { get; set; } 
  //[Column("IPO_OBJEKTAS")] public Geometry? IPO_OBJEKTAS { get; set; } 
}
