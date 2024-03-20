namespace LGT.Geolis.Geoldba;
[Table(name: "GIS_SCHEM_SLUOKSNIAI", Schema = "GEOLDBA")]
public class GIS_SCHEM_SLUOKSNIAI
{
  [Key]
  [Column("SCS_ID")] public int SCS_ID { get; set; }
  [Required] public Geoldba.GG_GRAFIKOS_TIPAI? GG_GRAFIKOS_TIPAI { get; set; } 
  [Column("SCS_TGT_TRUMP")] public string GG_GRAFIKOS_TIPAIId { get; set; } = default!;
	//[Column("SCS_TST_ID")] public int SCS_TST_ID { get; set; } 
	//[Column("SCS_GSL_ID")] public int? SCS_GSL_ID { get; set; } 
	[Column("SCS_PAVADINIMAS")] public string Name { get; set; } = default!;
	override public string ToString() => this.Name;
  //[Column("SCS_EILES_NR")] public int? SCS_EILES_NR { get; set; }  // Erdvinių duomenų grafinis primityvas
  //[Column("SCS_ATV_TIPAS")] public string SCS_ATV_TIPAS { get; set; } 
  //[Column("SCS_OBJEKTU_TIPAS")] public string SCS_OBJEKTU_TIPAS { get; set; } 
  public ICollection<GIS_TELKINIU_SCHEMU_SLUOKSNIAI>? TelkiniuSchemuSluoksniai { get; set; }
}
