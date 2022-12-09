namespace LGT.Core.Inv;
[Table(name: "LGT_SUT_PRIEDAI", Schema = "INV")]
public class SutartiesPriedas
{
  [NotMapped] // TODO: Map
  [Column("LGTP_ID")]
  public int LGTP_ID { get; set; } //LGTP_ID->NUMBER(5,0)->No->->1->
  [NotMapped] // TODO: Map
  [Column("LGTP_LGTS_ID")]
  public int LGTP_LGTS_ID { get; set; } //LGTP_LGTS_ID->NUMBER(5,0)->No->->2->
  [NotMapped] // TODO: Map
  [Column("LGTP_LGTD_TRUMP")]
  public string? LGTP_LGTD_TRUMP { get; set; } //LGTP_LGTD_TRUMP->VARCHAR2(10 BYTE)->Yes->->3->
  [NotMapped] // TODO: Map
  [Column("LGTP_DAZNIS")]
  public string? LGTP_DAZNIS { get; set; } //LGTP_DAZNIS->VARCHAR2(30 BYTE)->Yes->->4->
  [NotMapped] // TODO: Map
  [Column("LGTP_FORMATAS")]
  public string? LGTP_FORMATAS { get; set; } //LGTP_FORMATAS->VARCHAR2(200 BYTE)->Yes->->5->
  [NotMapped] // TODO: Map
  [Column("LGTP_SALYGOS")]
  public string? LGTP_SALYGOS { get; set; } //LGTP_SALYGOS->VARCHAR2(200 BYTE)->Yes->->6->
  [NotMapped] // TODO: Map
  [Column("LGTP_APMOKEJIMAS")]
  public string? LGTP_APMOKEJIMAS { get; set; } //LGTP_APMOKEJIMAS->VARCHAR2(30 BYTE)->Yes->->7->
  [NotMapped] // TODO: Map
  [Column("LGTP_AU_DATA")]
  public DateTime? LGTP_AU_DATA { get; set; } //LGTP_AU_DATA->DATE->Yes->->8->
  [NotMapped] // TODO: Map
  [Column("LGTP_AU_VARTOTOJAS")]
  public string? LGTP_AU_VARTOTOJAS { get; set; } //LGTP_AU_VARTOTOJAS->VARCHAR2(30 BYTE)->Yes->->9->
}