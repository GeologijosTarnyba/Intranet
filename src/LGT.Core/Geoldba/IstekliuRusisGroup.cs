namespace LGT.Core.Geoldba;
[Table(name: "ISTEKLIU_MAPX_GRUPES", Schema = "GEOLDBA")]
public class IštekliųRusisGroup
{
  public ICollection<IstekliuRusis> Instances { get; set; }
  [Key]
  [Column("IMG_MAPX_GRUPE")]
  public string ID { get; set; } //IMG_MAPX_GRUPE->VARCHAR2(10 BYTE)->No->->1->
  [Column("IMG_MAPX_PAVADINIMAS")]
  public string Name { get; set; } //IMG_MAPX_PAVADINIMAS->VARCHAR2(50 BYTE)->No->->2->
}
