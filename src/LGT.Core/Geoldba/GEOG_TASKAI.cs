namespace LGT.Core.Geoldba;
[Table(name: "GEOG_TASKAI", Schema = "GEOLDBA")]
public class GEOG_TASKAI
{
  public ICollection<Grezinys> Greziniai { get; set; }
  /// <summary>
  /// Geografinio taško kodas, pirminis raktas
  /// </summary>
  [Key]
  [Column("GEOT_KOD")]
  public int ID { get; set; } //GEOT_KOD->NUMBER(6,0)->No->->1->Geografinio taško kodas, pirminis raktas
  /// <summary>
  /// Rytų ilguma (laipsniai, minutės, sekundės ir sekundės dalys)
  /// </summary>
  [Column("GEOT_R_ILG")]
  public decimal Ilguma { get; set; } //GEOT_R_ILG->NUMBER(8,2)->No->->2->Rytų ilguma (laipsniai, minutės, sekundės ir sekundės dalys)
  /// <summary>
  /// Šiaurės platuma (laipsniai, minutės, sekundės ir sekundės dalys)
  /// </summary>
  [Column("GEOT_S_PLAT")]
  public decimal Platuma { get; set; } //GEOT_S_PLAT->NUMBER(8,2)->No->->3->Šiaurės platuma (laipsniai, minutės, sekundės ir sekundės dalys)
  /// <summary>
  /// Koordinatė Y (rytu ilguma) stačiakampių koordinačių sistemoje
  /// </summary>
  [Column("GEOT_Y")]
  public int Y { get; set; } //GEOT_Y->NUMBER(7,0)->No->->4->Koordinatė Y (rytu ilguma) stačiakampių koordinačių sistemoje
  /// <summary>
  /// Koordinatė X (šiaures platuma) stačiakampių koordinačių sistemoje
  /// </summary>
  [Column("GEOT_X")]
  public int X { get; set; } //GEOT_X->NUMBER(7,0)->No->->5->Koordinatė X (šiaures platuma) stačiakampių koordinačių sistemoje
  /// <summary>
  /// EPAS sistemos įrašo identifikatorius
  /// </summary>
  [NotMapped]
  [Column("GEOT_EPAS_ID")]
  public Int64? GEOT_EPAS_ID { get; set; } //GEOT_EPAS_ID->NUMBER(38,0)->Yes->->6->EPAS sistemos įrašo identifikatorius
}
