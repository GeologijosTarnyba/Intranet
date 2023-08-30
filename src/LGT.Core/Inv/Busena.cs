namespace LGT.Core.Inv;
[Table(name: "INV_IR_BUSENOS", Schema = "INV")]
public class Busena
{
  [Key]
  [Column("BUS_SUTR")]
  public string ID { get; set; } //BUS_SUTR->VARCHAR2(5 BYTE)->No->->1->
  [Column("BUS_PAV")]
  public string? Name { get; set; } //BUS_PAV->VARCHAR2(25 BYTE)->Yes->->2->
}


