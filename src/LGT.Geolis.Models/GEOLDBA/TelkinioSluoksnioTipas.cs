namespace LGT.Geolis.Geoldba;
[Table(name: "APIB_SL_TIP", Schema = "GEOLDBA")]
public class TelkinioSluoksnioTipas
{
  [Column("AST_TRUMP")]
  public string ID { get; set; } = default!; //AST_TRUMP->VARCHAR2(10 BYTE)->No->->1->Sutrumpintas sluoksnio tipo pavadinimas.
	[Column("AST_PAV")]
  public string Name { get; set; } = default!; //AST_PAV->VARCHAR2(70 BYTE)->No->->2->Pilnas sluoksnio tipo pavadinimas.
	public override string ToString() => $"{this.Name}[{this.ID}]";
}
