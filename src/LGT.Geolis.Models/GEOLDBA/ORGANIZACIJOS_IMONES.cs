namespace LGT.Geolis.Geoldba;
[Table(name: "ORGANIZACIJOS_IMONES", Schema = "GEOLDBA")]
public class ORGANIZACIJOS_IMONES
{
  [Key]
  [Column("OI_KOD")] public int ID { get; set; }  // Imones registracijos kodas. Imonems, registruotoms ne Lietuvoje, rekomenduojama prieš kodą įrašyti šalies kodą, pvz. LV1225427' Ukininkams, registracijos koda pradeti "UP" - ukininko pazymejimas arba UK- ž.ukio kodas"
  [Column("OI_PAV")] public string Name1 { get; set; } = default!;
	[Column("OI_REG_KOD")] public string? JARKodas { get; set; }  // Imones registracijos kodas. Imonems, registruotoms ne Lietuvoje, rekomenduojama prieš kodą įrašyti šalies kodą, pvz. "LV1225427'
  [Column("OI_TRUMPINYS")] public string? NameShort { get; set; }
  //[Column("OI_VEIKIANTI")] public string? OI_VEIKIANTI { get; set; } 
  [Column("OI_ADR")] public string? Address { get; set; }
  //[Column("OI_REG_PAP")] public string? OI_REG_PAP { get; set; } 
  //[Column("OI_OI_KOD")] public int? OI_OI_KOD { get; set; } 
  //[Column("OI_VARTOTOJAS")] public string? OI_VARTOTOJAS { get; set; } 
  //[Column("OI_DATA")] public DateTime? OI_DATA { get; set; } 
  //[Column("OI_PVM_KOD")] public string? OI_PVM_KOD { get; set; } 
  //[Column("OI_REG_KOD_S")] public string? OI_REG_KOD_S { get; set; }  // senuju registro kodu kopija (gal kada prireiks)
  //[Column("OI_EPAS_ID")] public Int64? OI_EPAS_ID { get; set; }  // EPAS sistemos įrašo identifikatorius
  //[Column("OI_REG_ID")] public int? OI_REG_ID { get; set; }  // Išorinis raktas į REGIONAI
  [Column("OI_PAVADINIMAS")] public string? Name2 { get; set; }
}
