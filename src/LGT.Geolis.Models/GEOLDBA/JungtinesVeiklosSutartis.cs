namespace LGT.Geolis.Geoldba;
[Table(name: "JUNGTINES_VEIKLOS_SUTARTYS", Schema = "GEOLDBA")]
public class JungtinesVeiklosSutartis
{
  [Key]
  [Column(name: "JVS_ID")]
  public int ID { get; set; } //JVS_ID->NUMBER(5,0)->No->->1->
  [Column(name: "JVS_DATA")]
  public DateTime SudarytaAt { get; set; } //JVS_DATA->DATE->No->->2->JVS sudarymo data
  [Column(name: "JVS_NUMERIS")]
  public string Name { get; set; } = default!; //JVS_NUMERIS->VARCHAR2(20 BYTE)->No->->3->JVS numeris
	[Column(name: "JVS_DATA_NUO")]
  public DateTime EffectiveSince { get; set; } //JVS_DATA_NUO->DATE->No->->4->Sutarties galiojimo pradžia
  [Column(name: "JVS_DATA_IKI")]
  public DateTime? EffectiveUntil { get; set; } //JVS_DATA_IKI->DATE->Yes->->5->Sutarties galiojimo pabaiga
  [Column(name: "JVS_VIETA")]
  public string? LocationName { get; set; } //JVS_VIETA->VARCHAR2(20 BYTE)->Yes->->6->Sutarties sudarymo vieta
  [Column(name: "JVS_PASTABOS")]
  public string? Pastabos { get; set; } //JVS_PASTABOS->VARCHAR2(100 BYTE)->Yes->->7->Sutarties objektas, pavadinimas, kita informacija
  [Column(name: "JVS_ATSTOVAS_FASM_ID")]
  public int? AtstovasAsmuoID { get; set; } //JVS_ATSTOVAS_FASM_ID->NUMBER(7,0)->Yes->->8->JVS grupės igaliotas asmuo (fizinis asmuo)
  public Asmuo? AtstovasAsmuo { get ;set; }
  [Column(name: "JVS_ATSTOVAS_OI_KOD")]
  public int? AtstovasJuridinisAsmuoID { get; set; } //JVS_ATSTOVAS_OI_KOD->NUMBER(5,0)->Yes->->9->JVS grupės igaliotas asmuo (juridinis asmuo)
  public JuridinisAsmuo? AtstovasJuridinisAsmuo { get; set; }

  [NotMapped][Column(name: "JVS_EPAS_ID")]
  public int? JVS_EPAS_ID { get; set; } //JVS_EPAS_ID->NUMBER(38,0)->Yes->->10->EPAS sistemos įrašo identifikatorius
  [NotMapped][Column(name: "JVS_AU_VARTOTOJAS")]
  public string? JVS_AU_VARTOTOJAS { get; set; } //JVS_AU_VARTOTOJAS->VARCHAR2(30 BYTE)->Yes->->11->
  public override string ToString() => $"{this.Name}[{this.ID}]";
}
