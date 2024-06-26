﻿namespace LGT.Geolis.INV;
[Table(name: "INV", Schema = "INV")]
public class InventoriausVieta
{
  [Key]
  [Column("INV_IR_INV_NR")] public string ID { get; set; } = default!;  //INV_IR_INV_NR->VARCHAR2(10 BYTE)->No->->1->
  [Required] public Iranga? Iranga { get; set; }
  [Column("INV_ASM_ID")] public int? AsmuoID { get; set; } //INV_ASM_ID->NUMBER(11,0)->Yes->->2->
  public Geoldba.Asmuo? Asmuo { get;set;}
  [Column("INV_DV_PAVADINIMAS")] public string DarboVietaID { get; set; } = default!;  //INV_DV_PAVADINIMAS->VARCHAR2(15 BYTE)->No->->3->
  [Required] public DarboVieta? DarboVieta { get;set;}
  
  [Column("INV_KIEKIS")] public int? Count { get; set; } //INV_KIEKIS->NUMBER(5,0)->Yes->->4->
}
