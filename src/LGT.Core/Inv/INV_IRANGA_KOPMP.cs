namespace LGT.Core.Inv;
[Table(name: "INV_IRANGA_KOPMP", Schema = "INV")]
public class INV_IRANGA_KOPMP
{
  [NotMapped] // TODO: Map
  [Column("IR_INV_NR")]
  public string? IR_INV_NR { get; set; } //IR_INV_NR->VARCHAR2(10 BYTE)->Yes->->1->
  [NotMapped] // TODO: Map
  [Column("IR_PAJ_DATA")]
  public DateTime? IR_PAJ_DATA { get; set; } //IR_PAJ_DATA->DATE->Yes->->2->
  [NotMapped] // TODO: Map
  [Column("IR_APRASYMAS")]
  public string IR_APRASYMAS { get; set; } //IR_APRASYMAS->VARCHAR2(200 BYTE)->No->->3->
  [NotMapped] // TODO: Map
  [Column("IR_PASTABA")]
  public string? IR_PASTABA { get; set; } //IR_PASTABA->VARCHAR2(250 BYTE)->Yes->->4->
  [NotMapped] // TODO: Map
  [Column("IR_ATS_ASM_ID")]
  public int IR_ATS_ASM_ID { get; set; } //IR_ATS_ASM_ID->NUMBER(7,0)->No->->5->
  [NotMapped] // TODO: Map
  [Column("IR_TIP_SUTR")]
  public string? IR_TIP_SUTR { get; set; } //IR_TIP_SUTR->VARCHAR2(5 BYTE)->Yes->->6->
  [NotMapped] // TODO: Map
  [Column("IR_BUS_SUTR")]
  public string? IR_BUS_SUTR { get; set; } //IR_BUS_SUTR->VARCHAR2(5 BYTE)->Yes->->7->
  [NotMapped] // TODO: Map
  [Column("IR_PRG_LIC")]
  public string? IR_PRG_LIC { get; set; } //IR_PRG_LIC->VARCHAR2(50 BYTE)->Yes->->8->
  [NotMapped] // TODO: Map
  [Column("IR_IR_INV_NR")]
  public string? IR_IR_INV_NR { get; set; } //IR_IR_INV_NR->VARCHAR2(10 BYTE)->Yes->->9->
  [NotMapped] // TODO: Map
  [Column("IR_TECH_PARAM")]
  public string? IR_TECH_PARAM { get; set; } //IR_TECH_PARAM->VARCHAR2(250 BYTE)->Yes->->10->
  [NotMapped] // TODO: Map
  [Column("IR_KAINA")]
  public Int64? IR_KAINA { get; set; } //IR_KAINA->NUMBER->Yes->->11->
  [NotMapped] // TODO: Map
  [Column("IR_GARANTIJA_IKI")]
  public DateTime? IR_GARANTIJA_IKI { get; set; } //IR_GARANTIJA_IKI->DATE->Yes->->12->
  [NotMapped] // TODO: Map
  [Column("IR_KAINA_EUR")]
  public Int64? IR_KAINA_EUR { get; set; } //IR_KAINA_EUR->NUMBER->Yes->->13->
}