namespace LGT.Core.Adresai;
[Table(name: "ATV", Schema = "ADRESAI")]
public class ATV
{
  [Key]
  [Column("ATV_ID")]
  public string ATV_ID { get; set; } //ATV_ID->VARCHAR2(20 BYTE)->No->->3->
  [Column("ATV_ID_ID")]
  public string? ParentID { get; set; } //ATV_ID_ID->VARCHAR2(20 BYTE)->Yes->NULL->1->
  public ATV? Parent { get; set; }
  [Column("ATV_PAV")]
  public string Name { get; set; } //ATV_PAV->VARCHAR2(100 BYTE)->No->->2->
  //[Column("ATV_PRI_ID")]public string? ATV_PRI_ID { get; set; } //ATV_PRI_ID->VARCHAR2(20 BYTE)->Yes->NULL->4->
}
