namespace LGT.Core.Geoldba;
[Table(name: "GR_KAD_KNYGU_PAKETAI", Schema = "GEOLDBA")]
public class GR_KAD_KNYGU_PAKETAI
{
  public ICollection<GR_KAD_KNYGOS> Knygos { get; set; }
  /// <summary>
  /// Gręžinių kadastro knygų paketo numeris, pirminis raktas
  /// </summary>
  [Key]
  [Column("GKKP_NR")]
  public string GKKP_NR { get; set; } //GKKP_NR->VARCHAR2(4 BYTE)->No->->1->Gręžinių kadastro knygų paketo numeris, pirminis raktas
}
