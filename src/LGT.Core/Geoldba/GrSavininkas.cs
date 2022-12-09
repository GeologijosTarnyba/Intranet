namespace LGT.Core.Geoldba;
[Table(name: "GR_SAVININKAI", Schema = "GEOLDBA")]
public class GrSavininkas
{
  public ICollection<Grezinys> Grezinys { get; set; } public int GrezinysCount { get; set; } = 0;
  /// <summary>
  /// Gręžinio savininko unikalus numeris, pirminis raktas
  /// </summary>
  [Key]
  [Column("GSAV_NR")]
  public int ID { get; set; } //GSAV_NR->NUMBER(6,0)->No->->1->Gręžinio savininko unikalus numeris, pirminis raktas
  /// <summary>
  /// Gręžinio savininko pavardė
  /// </summary>
  [Column("GSAV_PAVARDE")]
  public string Pavarde { get; set; } //GSAV_PAVARDE->VARCHAR2(50 BYTE)->No->->2->Gręžinio savininko pavardė
  /// <summary>
  /// Gręžinio savininko vardas
  /// </summary>
  [Column("GSAV_VARDAS")]
  public string Vardas { get; set; } //GSAV_VARDAS->VARCHAR2(20 BYTE)->No->->3->Gręžinio savininko vardas
  /// <summary>
  /// Savininko asmens kodas
  /// </summary>
  [Column("GSAV_ASMENS_KOD")]
  public Int64? AsmensKodas { get; set; } //GSAV_ASMENS_KOD->NUMBER(11,0)->Yes->->4->Savininko asmens kodas
  [Column("GSAV_ADRESAS")]
  public string? Adresas { get; set; } //GSAV_ADRESAS->VARCHAR2(50 BYTE)->Yes->->5->
  [NotMapped] // TODO: Map
  [Column("GSAV_ATV_ID")]
  public string? GSAV_ATV_ID { get; set; } //GSAV_ATV_ID->VARCHAR2(20 BYTE)->Yes->->6->
  /// <summary>
  /// EPAS sistemos įrašo identifikatorius
  /// </summary>
  [NotMapped] // TODO: Map
  [Column("GSAV_EPAS_ID")]
  public Int64? GSAV_EPAS_ID { get; set; } //GSAV_EPAS_ID->NUMBER(38,0)->Yes->->7->EPAS sistemos įrašo identifikatorius
  [NotMapped] // TODO: Map
  [Column("GSAV_AU_VARTOTOJAS")]
  public string? GSAV_AU_VARTOTOJAS { get; set; } //GSAV_AU_VARTOTOJAS->VARCHAR2(30 BYTE)->Yes->->8->
  [NotMapped] // TODO: Map
  [Column("GSAV_PVARDAS")]
  public string? GSAV_PVARDAS { get; set; } //GSAV_PVARDAS->VARCHAR2(50 BYTE)->Yes->->9->
}