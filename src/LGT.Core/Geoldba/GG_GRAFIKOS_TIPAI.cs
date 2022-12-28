namespace LGT.Core.Geoldba;
[Table(name: "GG_GRAFIKOS_TIPAI", Schema = "GEOLDBA")]
public class GG_GRAFIKOS_TIPAI
{
  public ICollection<GIS_ISTEKLIU_PLOTAI> GIS_ISTEKLIU_PLOTAI { get; set; }
  [Key]
  [Column("TGT_TRUMP")] public string ID { get; set; }
  [Column("TGT_PAV")] public string Name { get; set; }
  [Column("TGT_TGT_TRUMP")] public string? ParentID { get; set; } public GG_GRAFIKOS_TIPAI? Parent { get; set; } public ICollection<GG_GRAFIKOS_TIPAI> Children { get; set; }
}
