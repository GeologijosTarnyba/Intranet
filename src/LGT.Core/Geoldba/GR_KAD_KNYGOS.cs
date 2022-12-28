namespace LGT.Core.Geoldba;
[Table(name: "GR_KAD_KNYGOS", Schema = "GEOLDBA")]
public class GR_KAD_KNYGOS
{
  public ICollection<FondineKortele> FondinesKorteles { get; set; }
  /// <summary>
  /// Gręžinių kadastro knygos numeris, pirminis raktas
  /// Part of Key
  /// </summary>
  [Column("GKKN_NR")]
  public Int64 ID { get; set; } //GKKN_NR->NUMBER(3,0)->No->->1->Gręžinių kadastro knygos numeris, pirminis raktas
  /// <summary>
  /// Knygų paketo numeris, išorinis raktas į GR_KAD_KNYGU_PAKETAS
  /// Part of Key
  /// </summary>
  [Column("GKKN_GKKPAK_NR")]
  public string PaketasID { get; set; } //GKKN_GKKPAK_NR->VARCHAR2(4 BYTE)->No->->2->Knygų paketo numeris, išorinis raktas į GR_KAD_KNYGU_PAKETAS
  public GR_KAD_KNYGU_PAKETAI Paketas { get; set; }
}
