namespace LGT.Geolis.Geoldba;
[Table(name: "GIS_TELKINIU_SCHEMU_TIPAI", Schema = "GEOLDBA")]
public class GIS_TELKINIU_SCHEMU_TIPAI
{
  public ICollection<GIS_TELKINIO_SCHEMOS>? TelkiniuSchemos { get; set; }

  [Key]
  [Column("TST_ID")] public int TST_ID { get; set; }
  public IstekliuRusis? IstekliuRusis { get; set; }
  [Column("TST_IR_TRUMP")] public string IstekliuRusisID { get; set; } = default!;
	public GIS_SCHEMU_TIPAI? GIS_SCHEMU_TIPAI { get; set; }
  [Column("TST_SCT_ID")] public int GIS_SCHEMU_TIPAIID { get; set; }
}
