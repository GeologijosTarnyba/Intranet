namespace LGT.Geolis.Geoldba;
[Table(name: "GG_MASTELIAI", Schema = "GEOLDBA")]
public class GG_MASTELIAI
{
  public ICollection<GIS_ISTEKLIU_PLOTAI>? GIS_ISTEKLIU_PLOTAI { get; set; }
  [Key]
  [Column("MAST_TRUMP")] public Int64 ID { get; set; }
  [Column("MAST_PAV")] public string Name { get; set; } = default!;
}
