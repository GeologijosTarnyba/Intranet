using System.Collections;

namespace LGT.Geolis.Geoldba;
[Table(name: "GIS_TELKINIU_SCHEMU_SLUOKSNIAI", Schema = "GEOLDBA")]
public class GIS_TELKINIU_SCHEMU_SLUOKSNIAI
{
  [Key]
  [Column("TSS_ID")] public Int64 Id { get; set; }
  [Required] public GIS_TELKINIO_SCHEMOS? GIS_TELKINIO_SCHEMA { get; set; } 
  [Column("TSS_TSC_ID")] public int GIS_TELKINIO_SCHEMOSID { get; set; } 
  [Required] public GIS_SCHEM_SLUOKSNIAI? GIS_SCHEM_SLUOKSNIS { get; set; } 
  [Column("TSS_SCS_ID")] public int GIS_SCHEM_SLUOKSNIAIID { get; set; }

  public ICollection<GIS_TELKINIU_SCHEMU_EOBJ>? Eobjs { get; set; }

}
