namespace LGT.Core.Inv;
[Table(name: "LGT_SUTARTYS_PAKEIT", Schema = "INV")]
public class SutartiesPakeitimas
{
  [Key]
  [Column("LGTSP_ID")] public int LGTSP_ID { get; set; } //LGTSP_ID->NUMBER(5,0)->No->->1->
  [Column("LGTSP_PAKEITIMO_DATA")] public DateTime DateAt { get; set; } //LGTSP_PAKEITIMO_DATA->DATE->No->->2->
  [Column("LGTSP_PASTABOS")] public string Comment { get; set; } //LGTSP_PASTABOS->VARCHAR2(2000 BYTE)->No->->3->
  [Column("LGTSP_LGTS_ID")] public Int64 SutartisID { get; set; } //LGTSP_LGTS_ID->NUMBER->No->->4->
  public Sutartis Sutartis { get; set; }
}