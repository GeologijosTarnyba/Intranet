namespace LGT.Geolis.Geoldba;
[Table(name: "FONDINES_KORTELES", Schema = "GEOLDBA")]
public class FondineKortele
{
  /// <summary>
  /// Fondinės kortelės numeris, pirminis raktas
  /// </summary>
  [Key]
  [Column("FK_NR")]
  public string ID { get; set; } = default!; //FK_NR->VARCHAR2(20 BYTE)->No->->1->Fondinės kortelės numeris, pirminis raktas
	/// <summary>
	/// Gręžinių kadastro knygos numeris, išorinis raktas į GRĘŽINIŲ KADASTRO KNYGĄ
	/// </summary>
	[Column("FK_GKKNYG_NR")]
  public Int64 KnygaID { get; set; } //FK_GKKNYG_NR->NUMBER(3,0)->No->->2->Gręžinių kadastro knygos numeris, išorinis raktas į GRĘŽINIŲ KADASTRO KNYGĄ
  [Required] public GR_KAD_KNYGOS? Knyga { get; set; }
  /// <summary>
  /// Knygų paketo numeris, išorinis raktas į GRĘŽINIŲ KADASTRO KNYGĄ
  /// </summary>
  [Column("FK_GKKPAK_NR")]
  public string KnygaPaketasID { get; set; } = default!; //FK_GKKPAK_NR->VARCHAR2(4 BYTE)->No->->3->Knygų paketo numeris, išorinis raktas į GRĘŽINIŲ KADASTRO KNYGĄ
	/// <summary>
	/// Gręžiniui suteiktas unikalus numeris, išorinis raktas į GRĘŽINIAI
	/// </summary>

	[Column("FK_GR_NR")]
  public int GrezinysID { get; set; } //FK_GR_NR->NUMBER(6,0)->No->->4->Gręžiniui suteiktas unikalus numeris, išorinis raktas į GRĘŽINIAI
  [Required] public Grezinys? Grezinys { get; set; }
  ///// <summary>
  ///// EPAS sistemos įrašo identifikatorius
  ///// </summary>
  // [Column("FK_EPAS_ID")] public Int64? FK_EPAS_ID { get; set; } //FK_EPAS_ID->NUMBER(38,0)->Yes->->5->EPAS sistemos įrašo identifikatorius
}
