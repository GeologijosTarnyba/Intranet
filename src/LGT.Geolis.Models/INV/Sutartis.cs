namespace LGT.Geolis.INV;
[Table(name: "LGT_SUTARTYS", Schema = "INV")]
public class Sutartis
{
  public ICollection<SutartiesPriedas>? Priedai { get; set; }
  public ICollection<SutartiesPakeitimas>? Pakeitimai { get; set; }

  [Key]
  [Column("LGTS_ID")] public int ID { get; set; } //LGTS_ID->NUMBER(5,0)->No->->1->
  [Column("LGTS_NUMERIS")] public string? Numeris { get; set; } //LGTS_NUMERIS->VARCHAR2(200 BYTE)->Yes->->2->
  [Column("LGTS_PAVADINIMAS")] public string? Name { get; set; } //LGTS_PAVADINIMAS->VARCHAR2(200 BYTE)->Yes->->3->
  [Column("LGTS_SUDARYMO_DATA")] public DateTime? DateAt { get; set; } //LGTS_SUDARYMO_DATA->DATE->Yes->->4->
  [Column("LGTS_GALIOJA_IKI")] public DateTime? DateUntil { get; set; } //LGTS_GALIOJA_IKI->DATE->Yes->->5->
  [Column("LGTS_OBJEKTAS")] public string? SutartiesObjektas { get; set; } //LGTS_OBJEKTAS->VARCHAR2(2000 BYTE)->Yes->->6->
  [NotMapped] // TODO: Map
  [Column("LGTS_ATSVID_ASM_ID")]
  public int? LGTS_ATSVID_ASM_ID { get; set; } //LGTS_ATSVID_ASM_ID->NUMBER(7,0)->Yes->->7->
  [NotMapped] // TODO: Map
  [Column("LGTS_SUDISOR_OI_KOD")]
  public int? LGTS_SUDISOR_OI_KOD { get; set; } //LGTS_SUDISOR_OI_KOD->NUMBER(5,0)->Yes->->8->
  [NotMapped] // TODO: Map
  [Column("LGTS_SUDVID_OI_KOD")]
  public int? LGTS_SUDVID_OI_KOD { get; set; } //LGTS_SUDVID_OI_KOD->NUMBER(5,0)->Yes->->9->
  [NotMapped] // TODO: Map
  [Column("LGTS_ATSISOR_ASM")]
  public string? LGTS_ATSISOR_ASM { get; set; } //LGTS_ATSISOR_ASM->VARCHAR2(50 BYTE)->Yes->->10->
  [NotMapped] // TODO: Map
  [Column("LGTS_LGT_TIPAS")]
  public string? LGTS_LGT_TIPAS { get; set; } //LGTS_LGT_TIPAS->VARCHAR2(50 BYTE)->Yes->->11->
  [NotMapped] // TODO: Map
  [Column("LGTS_TEL_NR")]
  public string? LGTS_TEL_NR { get; set; } //LGTS_TEL_NR->VARCHAR2(25 BYTE)->Yes->->12->
  [NotMapped] // TODO: Map
  [Column("LGTS_KONTAKTAI")]
  public string? LGTS_KONTAKTAI { get; set; } //LGTS_KONTAKTAI->VARCHAR2(200 BYTE)->Yes->->13->
  [NotMapped] // TODO: Map
  [Column("LGTS_PASTABOS")]
  public string? LGTS_PASTABOS { get; set; } //LGTS_PASTABOS->VARCHAR2(200 BYTE)->Yes->->14->
  [NotMapped] // TODO: Map
  [Column("LGTS_AU_DATA")]
  public DateTime? LGTS_AU_DATA { get; set; } //LGTS_AU_DATA->DATE->Yes->->15->
  [NotMapped] // TODO: Map
  [Column("LGTS_AU_VARTOTOJAS")]
  public string? LGTS_AU_VARTOTOJAS { get; set; } //LGTS_AU_VARTOTOJAS->VARCHAR2(30 BYTE)->Yes->->16->
}
