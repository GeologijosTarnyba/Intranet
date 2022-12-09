namespace LGT.Core.Inv;
[Table(name: "INV_IRANGA", Schema = "INV")]
public class Iranga
{
  public InventoriausVieta? Vieta { get; set; }
  public ICollection<Remontas> Remontai { get; set; }
  [Key]
  [Column("IR_INV_NR")] public string ID { get; set; } //IR_INV_NR->VARCHAR2(10 BYTE)->No->->1->
  [Column("IR_PAJ_DATA")] public DateTime? DatePajamavimo { get; set; } //IR_PAJ_DATA->DATE->Yes->->2->
  [Column("IR_APRASYMAS")] public string Desc { get; set; } //IR_APRASYMAS->VARCHAR2(200 BYTE)->No->->3->
  [Column("IR_PASTABA")] public string? Comment { get; set; } //IR_PASTABA->VARCHAR2(250 BYTE)->Yes->->4->
  [Column("IR_ATS_ASM_ID")] public int AtsakingasAsmuoID { get; set; } //IR_ATS_ASM_ID->NUMBER(7,0)->No->->5->
  public Geoldba.Asmuo AtsakingasAsmuo { get;set;}
  [Column("IR_TIP_SUTR")] public string? TipasID { get; set; } //IR_TIP_SUTR->VARCHAR2(5 BYTE)->Yes->->6->
  public IrangosTipas? Tipas { get; set; }
  [Column("IR_BUS_SUTR")] public string? BusenaID { get; set; } //IR_BUS_SUTR->VARCHAR2(5 BYTE)->Yes->->7->
  public Busena? Busena { get; set; }
  [Column("IR_PRG_LIC")] public string? LicKey { get; set; } //IR_PRG_LIC->VARCHAR2(50 BYTE)->Yes->->8->
  [Column("IR_IR_INV_NR")] public string? ParentID { get; set; } //IR_IR_INV_NR->VARCHAR2(10 BYTE)->Yes->->9->
  public Iranga? Parent { get; set; }
  public ICollection<Iranga> Children { get; set; }
  [Column("IR_TECH_PARAM")] public string? TechParam { get; set; } //IR_TECH_PARAM->VARCHAR2(250 BYTE)->Yes->->10->
  [Column("IR_GARANTIJA_IKI")] public DateTime? DateGarantija { get; set; } //IR_GARANTIJA_IKI->DATE->Yes->->12->
  [Column("IR_KAINA_EUR")] public Int64? PriceEur { get; set; } //IR_KAINA_EUR->NUMBER->Yes->->13->
  [Column("IR_KAINA")] public Int64? PriceLT { get; set; } //IR_KAINA->NUMBER->Yes->->11->
}