namespace LGT.Core.Inv;
[Table(name: "LGT_KOMISIJOS", Schema = "INV")]
public class LGT_KOMISIJOS
{
  [NotMapped] // TODO: Map
  [Column("KOM_ID")]
  public int KOM_ID { get; set; } //KOM_ID->NUMBER(5,0)->No->->1->
  [NotMapped] // TODO: Map
  [Column("KOM_PAVADINIMAS")]
  public string KOM_PAVADINIMAS { get; set; } //KOM_PAVADINIMAS->VARCHAR2(250 BYTE)->No->->2->
  [NotMapped] // TODO: Map
  [Column("KOM_TVDOK_DATA")]
  public DateTime KOM_TVDOK_DATA { get; set; } //KOM_TVDOK_DATA->DATE->No->->3->
  [NotMapped] // TODO: Map
  [Column("KOM_TVDOK_NR")]
  public string KOM_TVDOK_NR { get; set; } //KOM_TVDOK_NR->VARCHAR2(20 BYTE)->No->->4->
  [NotMapped] // TODO: Map
  [Column("KOM_TVDOK_PAV")]
  public string? KOM_TVDOK_PAV { get; set; } //KOM_TVDOK_PAV->VARCHAR2(250 BYTE)->Yes->->5->
  [NotMapped] // TODO: Map
  [Column("KOM_PAN_NUO")]
  public DateTime? KOM_PAN_NUO { get; set; } //KOM_PAN_NUO->DATE->Yes->->6->
  [NotMapped] // TODO: Map
  [Column("KOM_PASTABA")]
  public string? KOM_PASTABA { get; set; } //KOM_PASTABA->VARCHAR2(250 BYTE)->Yes->->7->
}
