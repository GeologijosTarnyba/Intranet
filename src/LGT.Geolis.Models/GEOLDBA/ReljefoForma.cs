namespace LGT.Geolis.Geoldba;
[Table(name: "RELJEFO_FORMOS", Schema = "GEOLDBA")]
public class ReljefoForma
{
  /// <summary>
  /// Reljefo formos kodas, pirminis raktas
  /// </summary>
  [Key]
  [Column("RF_KOD")]
  public int ID { get; set; } //RF_KOD->NUMBER(3,0)->No->->1->Reljefo formos kodas, pirminis raktas
  /// <summary>
  /// Reljefo formos pavadinimas
  /// </summary>
  [Column("RF_PAV")]
  public string Name { get; set; } = default!; //RF_PAV->VARCHAR2(30 BYTE)->No->->2->Reljefo formos pavadinimas
}
