namespace LGT.Geolis.Geoldba;
[Table(name: "GIS_SCHEMU_TIPAI", Schema = "GEOLDBA")]
public class GIS_SCHEMU_TIPAI
{
  [Key]
  [Column("SCT_ID")] public int SCT_ID { get; set; }
  [Column("SCT_PAVADINIMAS")] public string SCT_PAVADINIMAS { get; set; } = default!;
	//[Column("SCT_SUSIETI_GAV_SKL")] public bool? SCT_SUSIETI_GAV_SKL { get; set; } 
}
