namespace LGT.Core.Geoldba;
[Table(name: "TEL_TYR", Schema = "GEOLDBA")]
public class Telkinys_Tyrimas
{
  public Telkinys Telkinys { get; set; } [Column("TT_TELK_KODAS")] public int TelkinysID { get; set; }  // Unikalus, aut. gen. kodas, skirtas ry?iui su grafika.
  public Tyrimas Tyrimas { get; set; } [Column("TT_TYRIM_SUTR")] public string TyrimasID { get; set; }  // Tyrimo pavadinimo sutrumpinimas, pirminis raktas
  [Column("TT_DATA")] public DateTime At { get; set; }  // Tyrimo atlikimo data
  public JuridinisAsmuo JuridinisAsmuo { get; set; } [Column("TT_ORGIM_KOD")] public int JuridinisAsmuoID { get; set; }  // Organizacijos/ ?mon?s kodas, pirminis raktas
}