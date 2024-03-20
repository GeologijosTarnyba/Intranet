namespace LGT.Geolis.Geoldba;
[Table(name: "IST_KAT", Schema = "GEOLDBA")]
public class IstekliuKategorija
{
  public ICollection<GIS_ISTEKLIU_PLOTAI>? GIS_ISTEKLIU_PLOTAI { get; set; }
  [Key]
  [Column("ISTK_KATEGORIJA")] public string ID { get; set; } = default!;  // Kategorijos pavadinimas.
	[Column("ISTK_APRASYMAS")] public string? Description { get; set; }  // Trumpas kategorijos aprašymas.
  [Column("ISTK_GALIOJA_IKI")] public DateTime? ValidUntil { get; set; }
  [Column("ISTK_APRASYMAS_P")] public string? Description2 { get; set; }
}
