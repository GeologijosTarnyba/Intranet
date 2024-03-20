namespace LGT.Geolis.Geoldba;
[Table(name: "GAVSKL_ISTEKLIAI", Schema = "GEOLDBA")]
public class GAVSKL_ISTEKLIAI
{
  [Column("GSI_GSKL_KODAS")] public int GavybosSklypasID { get; set; } 
  [Required] public GavybosSklypas? GavybosSklypas { get; set; }
  [Column("GSI_IST_TRUMP")] public string IstekliuRusisID { get; set; } = default!;
	[Required] public IstekliuRusis? IstekliuRusis { get; set; }
  [Column("GSI_IST_DATA")] public DateTime? GSI_IST_DATA { get; set; }
  [Column("GSI_IST_KIEKIS")] public decimal? GSI_IST_KIEKIS { get; set; }
  [Column("GSI_IST_KIEKIS_T")] public decimal? GSI_IST_KIEKIS_T { get; set; }
  [Column("GSI_FAKT_DATA")] public DateTime? GSI_FAKT_DATA { get; set; }
  [Column("GSI_FAKT_KIEKIS")] public decimal? GSI_FAKT_KIEKIS { get; set; }
  [Column("GSI_FAKT_KIEKIS_T")] public decimal? GSI_FAKT_KIEKIS_T { get; set; }
  [Column("GSI_GAV_KIEKIS")] public decimal? GSI_GAV_KIEKIS { get; set; }
  [Column("GSI_GAV_KIEKIS_T")] public decimal? GSI_GAV_KIEKIS_T { get; set; }
  //[Column("GSI_AU_DATA")] public DateTime? GSI_AU_DATA { get; set; } 
  //[Column("GSI_AU_VARTOTOJAS")] public string? GSI_AU_VARTOTOJAS { get; set; } 
}
