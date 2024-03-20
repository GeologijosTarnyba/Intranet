namespace LGT.Geolis.Geoldba;
[Table(name: "GG_GRAFIKOS_TIPAI", Schema = "GEOLDBA")]
public class GG_GRAFIKOS_TIPAI
{
  [Key]
  [Column("TGT_TRUMP")] public string Id { get; set; } = default!;
	[Column("TGT_PAV")] public string Name { get; set; } = default!;
	public override string ToString() => this.Name;
  [Column("TGT_TGT_TRUMP")] public string? ParentId { get; set; }
  public GG_GRAFIKOS_TIPAI? Parent { get; set; }
  public ICollection<GG_GRAFIKOS_TIPAI>? Children { get; set; }

  public ICollection<GIS_GRAFIKOS_ATRIBUTAI>? Instances { get; set; }
  
  public ICollection<GIS_TELKINIU_SCHEMU_EOBJ>? User_GIS_TELKINIU_SCHEMU_EOBJ { get; set; }
  public ICollection<GIS_ISTEKLIU_PLOTAI>? User_GIS_ISTEKLIU_PLOTAI { get; set; }
  public ICollection<GIS_SCHEM_SLUOKSNIAI>? User_GIS_SCHEM_SLUOKSNIAI { get; set; }
}
