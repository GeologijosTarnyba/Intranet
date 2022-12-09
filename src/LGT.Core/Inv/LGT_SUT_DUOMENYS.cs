namespace LGT.Core.Inv;
[Table(name: "LGT_SUT_DUOMENYS", Schema = "INV")]
public class LGT_SUT_DUOMENYS
{
  [NotMapped] // TODO: Map
  [Column("LGSD_ID")]
  public int LGSD_ID { get; set; } //LGSD_ID->NUMBER(5,0)->No->->1->
  [NotMapped] // TODO: Map
  [Column("LGSD_LGTP_ID")]
  public int LGSD_LGTP_ID { get; set; } //LGSD_LGTP_ID->NUMBER(5,0)->No->->2->
  [NotMapped] // TODO: Map
  [Column("LGSD_PAVADINIMAS")]
  public string? LGSD_PAVADINIMAS { get; set; } //LGSD_PAVADINIMAS->VARCHAR2(30 BYTE)->Yes->->3->
  [NotMapped] // TODO: Map
  [Column("LGSD_FORMATAS")]
  public string? LGSD_FORMATAS { get; set; } //LGSD_FORMATAS->VARCHAR2(30 BYTE)->Yes->->4->
  [NotMapped] // TODO: Map
  [Column("LGSD_APRASAS")]
  public string? LGSD_APRASAS { get; set; } //LGSD_APRASAS->VARCHAR2(200 BYTE)->Yes->->5->
  [NotMapped] // TODO: Map
  [Column("LGSD_PRIVALOMA")]
  public string? LGSD_PRIVALOMA { get; set; } //LGSD_PRIVALOMA->VARCHAR2(10 BYTE)->Yes->->6->
}