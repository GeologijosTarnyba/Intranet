namespace LGT.Core.Geoldba;
[Table(name: "ORGANIZACIJOS_IMONES", Schema = "GEOLDBA")]
public class JuridinisAsmuo
{
  public ICollection<Leidimas> Leidimai { get; set; }
  public ICollection<JungtinesVeiklosSutartis> JungtinesVeiklosSutartys_UzKuriasAtsakingas { get; set; }
  [Key][Column(name: "OI_KOD")]
  public int ID { get; set; } // Imones registracijos kodas. Imonems, registruotoms ne Lietuvoje, rekomenduojama prieš kodą įrašyti šalies kodą, pvz. LV1225427' Ukininkams, registracijos koda pradeti "UP" - ukininko pazymejimas arba UK- ž.ukio kodas"
  [Column(name: "OI_PAV")] public string Name1 { get; set; } //OI_PAV->VARCHAR2(100 BYTE)->No->->2->
  [Column(name: "OI_TRUMPINYS")] public string? NameShort { get; set; } //OI_TRUMPINYS->VARCHAR2(10 BYTE)->Yes->->4->
  /// <summary>
  /// Imones registracijos kodas. Imonems, registruotoms ne Lietuvoje, rekomenduojama prieš kodą įrašyti šalies kodą, pvz. "LV1225427'
  /// </summary>
  [Column(name: "OI_REG_KOD")] public string? JARKodas { get; set; } //OI_REG_KOD->VARCHAR2(10 BYTE)->Yes->->3->Imones registracijos kodas. Imonems, registruotoms ne Lietuvoje, rekomenduojama prieš kodą įrašyti šalies kodą, pvz. "LV1225427'
  //[Column(name: "OI_VEIKIANTI")] public string? OI_VEIKIANTI { get; set; } //OI_VEIKIANTI->VARCHAR2(1 BYTE)->Yes->->5->
  [Column(name: "OI_ADR")] public string? OI_ADR { get; set; } //OI_ADR->VARCHAR2(100 BYTE)->Yes->->6->
  //[Column(name: "OI_REG_PAP")] public string? OI_REG_PAP { get; set; } //OI_REG_PAP->VARCHAR2(1 BYTE)->Yes->->7->
  //[Column(name: "OI_OI_KOD")] public int? OI_OI_KOD { get; set; } //OI_OI_KOD->NUMBER(5,0)->Yes->->8->
  //[Column(name: "OI_VARTOTOJAS")] public string? OI_VARTOTOJAS { get; set; } //OI_VARTOTOJAS->VARCHAR2(30 BYTE)->Yes->->9->
  //[Column(name: "OI_DATA")] public DateTime? OI_DATA { get; set; } //OI_DATA->DATE->Yes->->10->
  //[Column(name: "OI_PVM_KOD")] public string? OI_PVM_KOD { get; set; } //OI_PVM_KOD->VARCHAR2(11 BYTE)->Yes->->11->
  //[Column(name: "OI_REG_KOD_S")] //public string? OI_REG_KOD_S { get; set; } //OI_REG_KOD_S->VARCHAR2(10 BYTE)->Yes->->12->senuju registro kodu kopija (gal kada prireiks)
  //[Column(name: "OI_EPAS_ID")] //public int? OI_EPAS_ID { get; set; } //OI_EPAS_ID->NUMBER(38,0)->Yes->->13->EPAS sistemos įrašo identifikatorius
  //[Column(name: "OI_REG_ID")] //public int? OI_REG_ID { get; set; } //OI_REG_ID->NUMBER(2,0)->Yes->->14->Išorinis raktas į REGIONAI
  [Column(name: "OI_PAVADINIMAS")] public string? Name2 { get; set; } //OI_PAVADINIMAS->VARCHAR2(200 BYTE)->Yes->->15->
}
