namespace LGT.Geolis.Geoldba;
[Table(name: "GIS_TELKINIU_SCHEMU_EOBJ", Schema = "GEOLDBA")]
public class GIS_TELKINIU_SCHEMU_EOBJ
{
  [Key]
  [Column("TSO_ID")] public Int64 Id { get; set; }  // Telkinio schemos erdvinio objekto unikalus identifikatorius.
  [Required] public GG_GRAFIKOS_TIPAI? GG_GRAFIKOS_TIPAS { get; set; }
  [Column("TSO_TGT_TRUMP")] public string GG_GRAFIKOS_TIPASID { get; set; } = default!;  // Mastelio sutrumpinimas, identifikatorius
	[Required] public GIS_TELKINIU_SCHEMU_SLUOKSNIAI? GIS_TELKINIU_SCHEMU_SLUOKSNIS { get; set; } 
  [Column("TSO_TSS_ID")] public Int64 GIS_TELKINIU_SCHEMU_SLUOKSNISID { get; set; } = default!;  // Telkinio schemos sluoksnio unikalus identifikatorius.

	[Column("TSO_MI_STILIUS")] public string TSO_MI_STILIUS { get; set; } = default!;
	//[Column("TSO_OBJEKTAS")] public Geometry TSO_OBJEKTAS { get; set; } // Telkinio schemos sluoksnio objekto erdvinis objektas Oracle Spatial SDO_GEOMETRY formatu.
	//[NotMapped]
	//public float X { get; set; }
	[Required] public XY<Int64>? XY { get; set; }

  public ICollection<GIS_GRAFIKOS_ATRIBUTU_REIKSMES>? GrafikosAtributai { get; set; }
}
