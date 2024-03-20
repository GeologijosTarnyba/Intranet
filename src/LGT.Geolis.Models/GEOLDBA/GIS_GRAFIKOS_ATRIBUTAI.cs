namespace LGT.Geolis.Geoldba;
[Table(name: "GIS_GRAFIKOS_ATRIBUTAI", Schema = "GEOLDBA")]
public class GIS_GRAFIKOS_ATRIBUTAI
{
  [Key]
  [Column("GRA_ID")] public int Id { get; set; }
  [Required] public GG_GRAFIKOS_TIPAI? GG_GRAFIKOS_TIPAI { get; set; }
  [Column("GRA_TGT_TRUMP")] public string GG_GRAFIKOS_TIPAIId { get; set; } = default!;
	[Column("GRA_PAVADINIMAS")] public string GRA_PAVADINIMAS { get; set; } = default!;
	//[Column("GRA_TIPAS")] public string GRA_TIPAS { get; set; }  // Erdvinių objektų grafinis primityvas (taškas, linija, poligonas)
	//[Column("GRA_SIMBOLIU_SK")] public int? GRA_SIMBOLIU_SK { get; set; } 
	//[Column("GRA_SIMBOLIU_SK_PO_KABLELIO")] public int? GRA_SIMBOLIU_SK_PO_KABLELIO { get; set; } 
	//[Column("GRA_PASTABOS")] public string? GRA_PASTABOS { get; set; } 
	public override string ToString() => this.GRA_PAVADINIMAS;
}
