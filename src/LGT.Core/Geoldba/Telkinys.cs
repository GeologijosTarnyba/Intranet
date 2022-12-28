namespace LGT.Core.Geoldba;
[Table(name: "TELKINIAI", Schema = "GEOLDBA")]
public class Telkinys
{
  #region View
  //public ICollection<Views.W_ZGR_MARKSEID_PLANAI> W_ZGR_MARKSEID_PLANAI { get; set; }
  #endregion

  public ICollection<GIS_ISTEKLIU_PLOTAI> GIS_ISTEKLIU_PLOTAI { get; set; }
  public ICollection<TELK_AKTYV_LIKUTIS> AktyvusLikutis { get; set; }
  public ICollection<Telkinys_Tyrimas> TyrimaiAssignments { get; set; }
  public ICollection<GavybosSklypas> GavybosSklypai { get; set; }
  public ICollection<TelkinioSluoksnis> Sluoksniai { get; set; }
  public ICollection<ZGRLGavybosObjektas> ZGRLGavybosObjektai { get; set; }
  public ICollection<GREZINIO_PRIKL_TELK> GreziniaiAssignments { get; set; }


  [Key][Column(name: "TELK_KODAS")]
  public int ID { get; set; } //TELK_KODAS->NUMBER(5,0)->No->->1->Unikalus, aut. gen. kodas, skirtas ry?iui su grafika.
  [Column(name: "TELK_PAV")]
  public string Name { get; set; } //TELK_PAV->VARCHAR2(35 BYTE)->No->->3->Pagrindinis telkinio pavadinimas.
  public Telkinys? Parent { get; set; } [Column(name: "TELK_TELK_KODAS")]public int? ParentID { get; set; } //TELK_TELK_KODAS->NUMBER(5,0)->Yes->->17->"
  public ICollection<Telkinys> Children { get; set; }

  [Column(name: "TELK_IR_TRUMP")] public string? IstekliuRusisID { get; set; } //TELK_IR_TRUMP->VARCHAR2(10 BYTE)->Yes->->2->Sutrumpintas i?kasen? r??ies pavadinimas
  public IstekliuRusis IstekliuRusis { get; set; }
  //[Column(name: "TELK_GEOTASK_KOD")] public int TELK_GEOTASK_KOD { get; set; } //TELK_GEOTASK_KOD->NUMBER(6,0)->No->->4->Geografinio ta?ko kodas, pirminis raktas
  //[Column(name: "TELK_LEIDI_NR")] public string? TELK_LEIDI_NR { get; set; } //TELK_LEIDI_NR->VARCHAR2(1 BYTE)->Yes->->5->Iki 2010-09 buvo:Leidimo registracijos numeris ; Centro koordinaciu patikimumas: 'T' - patikimos
  //[Column(name: "TELK_ATV_KOD")] public int? TELK_ATV_KOD { get; set; } //TELK_ATV_KOD->NUMBER(5,0)->Yes->->6->Administracinio vieneto kodas, pirminis raktas
  //[Column(name: "TELK_GT_KOD")] public int? TELK_GT_KOD { get; set; } //TELK_GT_KOD->NUMBER(5,0)->Yes->->7->Gatv?s kodas, pirminis raktas
  //[Column(name: "TELK_NUMERIS")] public string? TELK_NUMERIS { get; set; } //TELK_NUMERIS->VARCHAR2(7 BYTE)->Yes->->8->Telkinio numeris kadastre.
  /// <summary>
  /// Papildomas telkinio pavadinimas.
  /// </summary>
  [Column(name: "TELK_ANTRAS_PAV")]
  public string? Name2 { get; set; } //TELK_ANTRAS_PAV->VARCHAR2(70 BYTE)->Yes->->9->Papildomas telkinio pavadinimas.
  /// <summary>
  /// Bendras telkinio plotas.
  /// </summary>
  [Column(name: "TELK_PLOTAS")] public float? TELK_PLOTAS { get; set; } //TELK_PLOTAS->NUMBER(5,1)->Yes->->10->Bendras telkinio plotas.
  //[Column(name: "TELK_VN_KONTAKTAS")] public int? TELK_VN_KONTAKTAS { get; set; } //TELK_VN_KONTAKTAS->NUMBER(6,0)->Yes->->11->
  //[Column(name: "TELK_IST_TRUMP")] public string TELK_IST_TRUMP { get; set; } //TELK_IST_TRUMP->VARCHAR2(10 BYTE)->No->->12->
  [Column(name: "TELK_ATV_ID")] public string AdrID { get; set; } //TELK_ATV_ID->VARCHAR2(20 BYTE)->No->->13->
  public Adresai.ATV Adr { get; set; }
  [Column(name: "TELK_PAP_ID")] public string? AdrPapID { get; set; } //TELK_PAP_ID->VARCHAR2(20 BYTE)->Yes->->14->
  public Adresai.PapildomasAdresas AdrPap { get; set; }
  /// <summary>
  /// Telkinio įregistravimo data
  /// </summary>
  [Column(name: "TELK_IREG_DATA")] public DateTime? Since { get; set; } //TELK_IREG_DATA->DATE->Yes->->15->
  /// <summary>
  /// Telkinio išregistravimo data
  /// </summary>
  [Column(name: "TELK_ISREG_DATA")] public DateTime? Until { get; set; } //TELK_ISREG_DATA->DATE->Yes->->16->

  public override string ToString()
  {
    return $"{this.Name}[{this.ID}]";
  }
}
