namespace LGT.Core.Inv;
[Table(name: "LGT_KOMISIJOS_NARIAI", Schema = "INV")]
public class LGT_KOMISIJOS_NARIAI
{
  [NotMapped] // TODO: Map
  [Column("KMN_ID")]
  public int KMN_ID { get; set; } //KMN_ID->NUMBER(5,0)->No->->1->
  [NotMapped] // TODO: Map
  [Column("KMN_KOM_ID")]
  public int KMN_KOM_ID { get; set; } //KMN_KOM_ID->NUMBER(5,0)->No->->2->
  [NotMapped] // TODO: Map
  [Column("KMN_ASM_ID")]
  public int KMN_ASM_ID { get; set; } //KMN_ASM_ID->NUMBER(7,0)->No->->3->
  [NotMapped] // TODO: Map
  [Column("KMN_PAREIGOS")]
  public string? KMN_PAREIGOS { get; set; } //KMN_PAREIGOS->VARCHAR2(50 BYTE)->Yes->->4->
  [NotMapped] // TODO: Map
  [Column("KMN_DATA_NUO")]
  public DateTime? KMN_DATA_NUO { get; set; } //KMN_DATA_NUO->DATE->Yes->->5->
  [NotMapped] // TODO: Map
  [Column("KMN_DATA_IKI")]
  public DateTime? KMN_DATA_IKI { get; set; } //KMN_DATA_IKI->DATE->Yes->->6->
  [NotMapped] // TODO: Map
  [Column("KMN_PASTABA")]
  public string? KMN_PASTABA { get; set; } //KMN_PASTABA->VARCHAR2(250 BYTE)->Yes->->7->
}