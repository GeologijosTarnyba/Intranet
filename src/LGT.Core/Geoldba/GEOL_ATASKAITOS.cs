namespace LGT.Core.Geoldba;
[Table(name: "GEOL_ATASKAITOS", Schema = "GEOLDBA")]
public class GEOLAtaskaita
{
  public ICollection<Grezinys> Greziniai { get; set; }
  /// <summary>
  /// Ataskaitos fondinis numeris, pirminis raktas
  /// </summary>
  [Key]
  [Column("GAT_FOND_NR")]
  public string ID { get; set; } //GAT_FOND_NR->VARCHAR2(10 BYTE)->No->->1->Ataskaitos fondinis numeris, pirminis raktas
}