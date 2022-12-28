namespace LGT.Core.Geoldba;
[Table(name: "PIRMINIAI_DOKUMENTAI", Schema = "GEOLDBA")]
public class PirminisDokumentas
{
  public ICollection<Grezinys> Greziniai { get; set; }
  /// <summary>
  /// Pirminio dokumento kodas, pirminis raktas
  /// </summary>
  [Key]
  [Column("PRDO_KOD")]
  public int ID { get; set; } //PRDO_KOD->NUMBER(6,0)->No->->1->Pirminio dokumento kodas, pirminis raktas
  /// <summary>
  /// Organizacijos suteiktas dokumento numeris
  /// </summary>
  [Column("PRDO_NR")]
  public string PRDO_NR { get; set; } //PRDO_NR->VARCHAR2(20 BYTE)->No->->2->Organizacijos suteiktas dokumento numeris
  /// <summary>
  /// Išorinis raktas į ORGANIZACIJOS/IMONES
  /// </summary>
  [NotMapped][Column("PRDO_ORGIM_KOD")] public int PRDO_ORGIM_KOD { get; set; } //PRDO_ORGIM_KOD->NUMBER(5,0)->No->->3->Išorinis raktas į ORGANIZACIJOS/IMONES
  /// <summary>
  /// Aprašamojo dokumento tipo sutrumpinimas, išorinis raktas į PIRMINIU_DOKUMENTU_TIPAI
  /// </summary>
  [Column("PRDO_PDTIP_SUTR")]
  public string TipasSutr { get; set; } //PRDO_PDTIP_SUTR->VARCHAR2(10 BYTE)->No->->4->Aprašamojo dokumento tipo sutrumpinimas, išorinis raktas į PIRMINIU_DOKUMENTU_TIPAI
  public PirminioDokumentoTipas Tipas { get; set; }
}
