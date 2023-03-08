namespace LGT.Core.Geoldba;
[Table(name: "GREZINIAI", Schema = "GEOLDBA")]
public class Grezinys
{
  public FondineKortele? FondineKortele { get; set; } // one to one relation, so no key.
  public ICollection<GREZINIO_PRIKL_TELK> TelkiniaiAssignments { get; set; }
  [Key]
  [Column("GR_NR")]
  public int ID { get; set; } //GR_NR->NUMBER(6,0)->No->->1->Gręžiniui suteiktas unikalus numeris, pirminis raktas
  /// <summary>
  /// Gręžinio gylis.
  /// </summary>
  [Column("GR_GYLIS")]
  public decimal Gylis { get; set; } //GR_GYLIS->NUMBER(6,2)->No->->2->Gręžinio gylis.
  /// <summary>
  /// Gręžinio išgręžimo data.
  /// </summary>
  [Column("GR_ISGREZIMO_DATA")]
  public DateTime IsgrezimoData { get; set; } //GR_ISGREZIMO_DATA->DATE->No->->3->Gręžinio išgręžimo data.
  /// <summary>
  /// Gręžinio žiočių absoliutinis aukštis.
  /// </summary>
  [Column("GR_ZIOCIU_ALTITUDE")]
  public decimal ZiociuAbsoliutinisAukstis { get; set; } //GR_ZIOCIU_ALTITUDE->NUMBER(6,2)->No->->4->Gręžinio žiočių absoliutinis aukštis.
  /// <summary>
  /// Geografinio taško kodas, išorinis raktas į GEOG_TASKAI
  /// </summary>
  [Column("GR_GEOTASK_KOD")]
  public int GeogTaskasID { get; set; } //GR_GEOTASK_KOD->NUMBER(6,0)->No->->5->Geografinio taško kodas, išorinis raktas į GEOG_TASKAI
  public GEOG_TASKAI GeogTaskas { get; set; }
  /// <summary>
  /// Išorinis raktas esantis ARC"e į A/T_VIENETAI, GATVES, VIETOVES
  /// </summary>
  [NotMapped] // TODO:map
  [Column("GR_NURODOMAS_KODU")]
  public int? GR_NURODOMAS_KODU { get; set; } //GR_NURODOMAS_KODU->NUMBER(5,0)->Yes->->6->Išorinis raktas esantis ARC"e į A/T_VIENETAI, GATVES, VIETOVES
  ///// <summary>
  ///// Nurodo išorinio rakto šaltinį A - A/T vienetas, G - gatvė, V - vietovė
  ///// </summary>
  // // TODO:map
  //[Column("GR_NURODOMAS_TIPU")]
  //public string? GR_NURODOMAS_TIPU { get; set; } //GR_NURODOMAS_TIPU->VARCHAR2(1 BYTE)->Yes->->7->Nurodo išorinio rakto šaltinį A - A/T vienetas, G - gatvė, V - vietovė
  /// <summary>
  /// Išorinis raktas į RELJEFO_FORMOS
  /// </summary>
  [Column("GR_RFORM_KOD")]
  public int? ReljefoFormaID { get; set; } //GR_RFORM_KOD->NUMBER(3,0)->Yes->->8->Išorinis raktas į RELJEFO_FORMOS
  public ReljefoForma? ReljefoForma { get; set; }
  /// <summary>
  /// Išorinis raktas į GR_SAVININKAI
  /// </summary>
  [Column("GR_PRIKL_GSAV_NR")]
  public int? SavininkasID { get; set; } //GR_PRIKL_GSAV_NR->NUMBER(4,0)->Yes->->9->Išorinis raktas į GR_SAVININKAI
  public GrSavininkas? Savininkas {get;set;}
  ///// <summary>
  ///// Išorinis raktas į ORGANIZACIJOS/IMONES (gręžinio savininkas)
  ///// </summary>
  // // TODO:map
  //[Column("GR_PRIKL_V_ORGIM_KOD")]
  //public int? GR_PRIKL_V_ORGIM_KOD { get; set; } //GR_PRIKL_V_ORGIM_KOD->NUMBER(5,0)->Yes->->10->Išorinis raktas į ORGANIZACIJOS/IMONES (gręžinio savininkas)
  ///// <summary>
  ///// Išorinis raktas į ORGANIZACIJAS/IMONES (išgręžusi gręžinį)
  ///// </summary>
  // // TODO:map
  [Column("GR_ISGR_ORGIM_KOD")]
  public int? IsgrezusiImoneID { get; set; } //GR_ISGR_ORGIM_KOD->NUMBER(5,0)->Yes->->11->Išorinis raktas į ORGANIZACIJAS/IMONES (išgręžusi gręžinį)
  public JuridinisAsmuo IsgrezusiImone { get; set; }
  /// <summary>
  /// Išorinis raktas į PIRMINIAI_DOKUMENTAI
  /// </summary>
  [Column("GR_PRDOK_KOD")]
  public int? PirminisDokumentasID { get; set; } //GR_PRDOK_KOD->NUMBER(6,0)->Yes->->12->Išorinis raktas į PIRMINIAI_DOKUMENTAI
  public PirminisDokumentas? PirminisDokumentas { get;set; }
  /// <summary>
  /// Ataskaitos fondinis numeris, išorinis raktas į GEOL_ATASKAITOS
  /// </summary>
  [Column("GR_GAT_FOND_NR")]
  public string? AtaskaitaID { get; set; } //GR_GAT_FOND_NR->VARCHAR2(10 BYTE)->Yes->->13->Ataskaitos fondinis numeris, išorinis raktas į GEOL_ATASKAITOS
  public GEOLAtaskaita? Ataskaita { get; set; }
  /// <summary>
  /// Gręžinio konfidencialumo pabaigos data
  /// </summary>
  [Column("GR_KONF_PABAIGA")]
  public DateTime? GR_KONF_PABAIGA { get; set; } //GR_KONF_PABAIGA->DATE->Yes->->14->Gręžinio konfidencialumo pabaigos data
  [Obsolete($"Grežiniai telkiniui priskiriami per {nameof(Geoldba.GREZINIO_PRIKL_TELK)} (this.{nameof(TelkiniaiAssignments)})")]
  [NotMapped()]
  [Column("GR_TELK_KOD")]
  public int? TelkinysID { get; set; } //GR_TELK_KOD->NUMBER(5,0)->Yes->->15->
  [Column("GR_ADRESAS")]
  public string? GR_ADRESAS { get; set; } //GR_ADRESAS->VARCHAR2(50 BYTE)->Yes->->16->
  //[Column("GR_PATIKIMAS")]
  //public string? GR_PATIKIMAS { get; set; } //GR_PATIKIMAS->VARCHAR2(1 BYTE)->Yes->->17->
  //[Column("GR_KERNAS")]
  //public string? GR_KERNAS { get; set; } //GR_KERNAS->VARCHAR2(1 BYTE)->Yes->->18->
  //[Column("GR_RANG_ORGIM_KOD")]
  //public int? GR_RANG_ORGIM_KOD { get; set; } //GR_RANG_ORGIM_KOD->NUMBER(5,0)->Yes->->19->
  //[Column("GR_ATV_ID")]
  //public string GR_ATV_ID { get; set; } //GR_ATV_ID->VARCHAR2(20 BYTE)->No->->20->
  // // TODO:map
  //[Column("GR_PAP_ATV_ID")]
  //public string? GR_PAP_ATV_ID { get; set; } //GR_PAP_ATV_ID->VARCHAR2(20 BYTE)->Yes->->21->
  // // TODO:map
  [Column("GR_IREG_DATA")]
  public DateTime? IregistravimoData { get; set; } //GR_IREG_DATA->DATE->Yes->->22->
  [Column("GR_ISREG_DATA")]
  public DateTime? IsregistravimoData { get; set; } //GR_ISREG_DATA->DATE->Yes->->23->
  [Column("GR_NTR_DATA")]
  public DateTime? GR_NTR_DATA { get; set; } //GR_NTR_DATA->DATE->Yes->->24->
  [Column("GR_NTR_NR")]
  public string? GR_NTR_NR { get; set; } //GR_NTR_NR->VARCHAR2(20 BYTE)->Yes->->25->
  [Column("GR_ILGIS")] public decimal? Ilgis { get; set; } //GR_ILGIS->NUMBER(7,2)->Yes->->26->
  [Column("GR_SAN_ZONA")] public decimal? GR_SAN_ZONA { get; set; } //GR_SAN_ZONA->NUMBER(7,2)->Yes->->27->
  [Column("GR_PATVIRTINTAS")] public string GR_PATVIRTINTAS { get; set; } //GR_PATVIRTINTAS->CHAR(1 BYTE)->No->T'->28->
  [Column("GR_PASTABA")] public string? GR_PASTABA { get; set; } //GR_PASTABA->VARCHAR2(250 BYTE)->Yes->->29->
  //[Column("GR_GAT_NR")] public string? GR_GAT_NR { get; set; } //GR_GAT_NR->VARCHAR2(10 BYTE)->Yes->->30->
  /// <summary>
  /// Atšakos gręžinio nr (kuriam gręžiniui priklauso atšaka)
  /// </summary>
  [Column("GR_GR_NR")]
  public int? ParentID { get; set; } //GR_GR_NR->NUMBER(6,0)->Yes->->31->Atšakos gręžinio nr (kuriam gręžiniui priklauso atšaka)
  public Grezinys? Parent { get; set; }
  /// <summary>
  /// Atšakos
  /// </summary>
  public ICollection<Grezinys> Children { get; set; }
  /// <summary>
  /// Gręžinio kirtavietės X koordinatė LKS sistemoje
  /// </summary>
  [Column("GR_KIRTAVIETES_X")]
  public decimal? Kirtavietes_X { get; set; } //GR_KIRTAVIETES_X->NUMBER(9,2)->Yes->->32->Gręžinio kirtavietės X koordinatė LKS sistemoje
  /// <summary>
  /// Gręžinio kirtavietės Y koordinatė LKS sistemoje
  /// </summary>
  [Column("GR_KIRTAVIETES_Y")]
  public decimal? Kirtavietes_Y { get; set; } //GR_KIRTAVIETES_Y->NUMBER(8,2)->Yes->->33->Gręžinio kirtavietės Y koordinatė LKS sistemoje
  /// <summary>
  /// EPAS sistemos įrašo identifikatorius
  /// </summary>
  [NotMapped] // TODO:map
  [Column("GR_EPAS_ID")]
  public int? GR_EPAS_ID { get; set; } //GR_EPAS_ID->NUMBER(38,0)->Yes->->34->EPAS sistemos įrašo identifikatorius
  /// <summary>
  /// Išorinis raktas į ASMENYS (pateikė)
  /// </summary>
  [Column("GR_ASM_ID_PATEIKE")]
  public int? PateikejasID { get; set; } //GR_ASM_ID_PATEIKE->NUMBER(7,0)->Yes->->35->Išorinis raktas į ASMENYS (pateikė)
  public Asmuo? Pateikejas { get; set; }
  /// <summary>
  /// Išorinis raktas į JUNGTINES_VEIKLOS_SUTARTYS (rangovas)
  /// </summary>
  [NotMapped] // TODO:map
  [Column("GR_JVS_ID_RANGOVAS")]
  public int? GR_JVS_ID_RANGOVAS { get; set; } //GR_JVS_ID_RANGOVAS->NUMBER(5,0)->Yes->->36->Išorinis raktas į JUNGTINES_VEIKLOS_SUTARTYS (rangovas)
  [NotMapped] // TODO:map
  [Column("GR_AU_VARTOTOJAS")]
  public string? GR_AU_VARTOTOJAS { get; set; } //GR_AU_VARTOTOJAS->VARCHAR2(30 BYTE)->Yes->->37->
  /// <summary>
  /// Išorinis raktas į ASMENYS (rangovas)
  /// </summary>
  [Column("GR_ASM_ID_RANGOVAS")]
  public int? RangovasID { get; set; } //GR_ASM_ID_RANGOVAS->NUMBER(7,0)->Yes->->38->Išorinis raktas į ASMENYS (rangovas)
  public Asmuo? Rangovas { get; set; }
  [Column("GR_ZIOCIU_X")]
  public decimal? Ziociu_X { get; set; } //GR_ZIOCIU_X->NUMBER(9,2)->Yes->->39->
  [Column("GR_ZIOCIU_Y")]
  public decimal? Ziociu_Y { get; set; } //GR_ZIOCIU_Y->NUMBER(8,2)->Yes->->40->
  /// <summary>
  /// Požymis, ar gręžinys buvo įvestas naudojantis LGTEP gręžinių legalizavimo el. paslauga
  /// </summary>
  [Column("GR_LEGALIZUOTAS")] // TODO: change to bool with converters case string? is "T" then true else false
  public string? GR_LEGALIZUOTAS { get; set; } //GR_LEGALIZUOTAS->VARCHAR2(1 BYTE)->Yes->->41->Požymis, ar gręžinys buvo įvestas naudojantis LGTEP gręžinių legalizavimo el. paslauga
}
