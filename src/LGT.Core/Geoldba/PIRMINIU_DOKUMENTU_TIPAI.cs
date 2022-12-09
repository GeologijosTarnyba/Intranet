namespace LGT.Core.Geoldba;
[Table(name: "PIRMINIAI_DOKUMENTU_TIPAI", Schema = "GEOLDBA")]
public class PirminioDokumentoTipas
{
  /// <summary>
  /// Pirminio dokumento tipo sutrumpinimas, pirminis raktas
  /// </summary>
  [Key]
  [Column("PDT_SUTR")]
  public string Sutr { get; set; } //PDT_SUTR->VARCHAR2(10 BYTE)->No->->1->Pirminio dokumento tipo sutrumpinimas, pirminis raktas
  /// <summary>
  /// Pirminio dokumento tipas
  /// </summary>
  [Column("PDT_TIPAS")]
  public string Name { get; set; } //PDT_TIPAS->VARCHAR2(50 BYTE)->No->->2->Pirminio dokumento tipas
}