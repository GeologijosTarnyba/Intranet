namespace LGT.Geolis.Geoldba;
[Table(name: "DOKUMENTU_TIPAI", Schema = "GEOLDBA")]
public class DokumentoTipas
{
  [Key]
  [Column("DOKR_SUTR")]
  public string ID { get; set; } = default!; //DOKR_SUTR->VARCHAR2(10 BYTE)->No->->2->
	[Column("DOKR_DOKR_SUTR")]
  public string? ParentID { get; set; } //DOKR_DOKR_SUTR->VARCHAR2(10 BYTE)->Yes->->1->
  public DokumentoTipas? Parent { get; set; }
  public ICollection<DokumentoTipas>? Children { get; set; }
  [Column("DOKR_TIPAS")]
  public string Name { get; set; } = default!; //DOKR_TIPAS->VARCHAR2(100 BYTE)->No->->3->
	#region NotMapped
	//[Column("DOKR_EPAS_ID")] public int? DOKR_EPAS_ID { get; set; } //DOKR_EPAS_ID->NUMBER(38,0)->Yes->->4->EPAS sistemos įrašo identifikatorius
	#endregion
}
