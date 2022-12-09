namespace LGT.Core.Inv;
[Table(name: "INV_SKYRIUS", Schema = "INV")]
public class Skyrius
{
  public ICollection<DarboVieta> DarboVietos { get; set; }
  [Key]
  [Column("SKY_SUTR")]
  public string ID { get; set; } //SKY_SUTR->VARCHAR2(5 BYTE)->No->->1->
  [Column("SKY_PAVADINIMAS")]
  public string? Name { get; set; } //SKY_PAVADINIMAS->VARCHAR2(100 BYTE)->Yes->->2->
}