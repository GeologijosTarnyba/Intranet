namespace LGT.Core.Inv;
[Table(name: "INV_IR_TIP", Schema = "INV")]
public class IrangosTipas
{
  [Key]
  [Column("TIP_SUTR")] public string ID { get; set; } //TIP_SUTR->VARCHAR2(5 BYTE)->No->->1->
  [Column("TIP_PAV")] public string? Name { get; set; } //TIP_PAV->VARCHAR2(25 BYTE)->Yes->->2->
}