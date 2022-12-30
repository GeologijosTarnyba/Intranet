namespace LGT.Core.Inv;
[Table(name: "INV_DARB_VIETA", Schema = "INV")]
public class DarboVieta
{
  public ICollection<InventoriausVieta> InventoriausVietos { get; set; }
  [Column("DV_KAB")] public string? Kabinetas { get; set; } //DV_KAB->VARCHAR2(9 BYTE)->Yes->->1->
  // // TODO: Map
  //[Column("DV_TV")]
  //public string? DV_TV { get; set; }
  [Column("DV_PASTABOS")] public string? Comment { get; set; } //DV_PASTABOS->VARCHAR2(100 BYTE)->Yes->->3->
  [Column("DV_SKY_SUTR")] public string? SkyriusID { get; set; } //DV_SKY_SUTR->VARCHAR2(5 BYTE)->Yes->->4->
  public Skyrius? Skyrius { get; set; }
  [Key]
  [Column("DV_PAVADINIMAS")] public string ID { get; set; } //DV_PAVADINIMAS->VARCHAR2(15 BYTE)->No->->5->
  [Column("DV_PANAIKINTA_NUO")] public DateTime? DateUntil { get; set; } //DV_PANAIKINTA_NUO->DATE->Yes->->6->
}
