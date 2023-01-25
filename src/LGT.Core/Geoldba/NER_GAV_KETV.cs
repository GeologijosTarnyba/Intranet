namespace LGT.Core.Geoldba;
[Table(name: "NER_GAV_KETV", Schema = "GEOLDBA")]
public class NER_GAV_KETV
{
  public NER_ISK_GAV? Apjungejas { get; set; }

  [Column("GAVK_GSKL_KODAS")] public int GavybosSklypasID { get; set; } //GAVK_GSKL_KODAS->NUMBER(6,0)->No->->1->
  public GavybosSklypas GavybosSklypas { get; set; }
  [Column("GAVK_AGS_SL_NR")] public int TelkinioSluoksnisID { get; set; } //GAVK_AGS_SL_NR->NUMBER(6,0)->No->->2->
  public TelkinioSluoksnis TelkinioSluoksnis { get; set; }
  [Column("GAVK_METAI")] public int GAVK_METAI { get; set; } //GAVK_METAI->NUMBER(4,0)->No->->3->
  [Column("GAVK_KETV")] public int GAVK_KETV { get; set; } //GAVK_KETV->NUMBER(2,0)->No->->4->
  [Column("GAVK_KIEKIS")] public decimal? GAVK_KIEKIS { get; set; } //GAVK_KIEKIS->NUMBER(8,3)->Yes->->5->
  [Column("GAVK_KIEKIS_T")] public decimal? GAVK_KIEKIS_T { get; set; } //GAVK_KIEKIS_T->NUMBER(8,3)->Yes->->6->
  [Column("GAVK_NUOSTOLIS")] public decimal? GAVK_NUOSTOLIS { get; set; } //GAVK_NUOSTOLIS->NUMBER(8,3)->Yes->->7->
  [Column("GAVK_NUOSTOLIS_T")] public decimal? GAVK_NUOSTOLIS_T { get; set; } //GAVK_NUOSTOLIS_T->NUMBER(8,3)->Yes->->8->
  [Column("GAVK_UZ_KONT")] public decimal? GAVK_UZ_KONT { get; set; } //GAVK_UZ_KONT->NUMBER(8,3)->Yes->->9->
  [Column("GAVK_UZ_KONT_T")] public decimal? GAVK_UZ_KONT_T { get; set; } //GAVK_UZ_KONT_T->NUMBER(8,3)->Yes->->10->
  [Column("GAVK_KIEKIS_TAME_TARPE")] public decimal? GAVK_KIEKIS_TAME_TARPE { get; set; } //GAVK_KIEKIS_TAME_TARPE->NUMBER(8,3)->Yes->->11->
  [Column("GAVK_KIEKIS_TAME_TARPE_T")] public decimal? GAVK_KIEKIS_TAME_TARPE_T { get; set; } //GAVK_KIEKIS_TAME_TARPE_T->NUMBER(8,3)->Yes->->12->
  /// <summary>
  /// Išteklių pasikeitimas dėl gavybos proceso (iki 10 % nuo viso) t.m3
  /// </summary>
  [Column("GAVK_NUOSTOLIS_TAME_TARPE")]
  public decimal? GAVK_NUOSTOLIS_TAME_TARPE { get; set; } //GAVK_NUOSTOLIS_TAME_TARPE->NUMBER(8,3)->Yes->->13->Išteklių pasikeitimas dėl gavybos proceso (iki 10 % nuo viso) t.m3
  /// <summary>
  /// Išteklių pasikeitimas dėl gavybos proceso (iki 10 % nuo viso) t.t
  /// </summary>
  [Column("GAVK_NUOSTOLIS_TAME_TARPE_T")]
  public decimal? GAVK_NUOSTOLIS_TAME_TARPE_T { get; set; } //GAVK_NUOSTOLIS_TAME_TARPE_T->NUMBER(8,3)->Yes->->14->Išteklių pasikeitimas dėl gavybos proceso (iki 10 % nuo viso) t.t
  /// <summary>
  /// Markseiderinio matavimo data
  /// </summary>
  
  [Column("GAVK_DOK_DATA")]
  public DateTime? MarkseidData { get; set; } //GAVK_DOK_DATA->DATE->Yes->->15->Markseiderinio matavimo data
  [Column("GAVK_PASTABA")]
  public string? GAVK_PASTABA { get; set; } //GAVK_PASTABA->VARCHAR2(250 BYTE)->Yes->->16->
  [Column("GAVK_AU_DATA")]
  public DateTime? GAVK_AU_DATA { get; set; } //GAVK_AU_DATA->DATE->Yes->->17->
  [Column("GAVK_AU_VARTOTOJAS")]
  public string? GAVK_AU_VARTOTOJAS { get; set; } //GAVK_AU_VARTOTOJAS->VARCHAR2(30 BYTE)->Yes->->18->
  /// <summary>
  /// Išteklių pasikeitimas: "peržvalgyti" ir patvirtinti ištekliai (prieaugis arba nurasymas) laikotarpio metu.
  /// </summary>
  [Column("GAVK_IST_PASIKEITIMAS")]
  public decimal? GAVK_IST_PASIKEITIMAS { get; set; } //GAVK_IST_PASIKEITIMAS->NUMBER(8,3)->Yes->->19->Išteklių pasikeitimas: "peržvalgyti" ir patvirtinti ištekliai (prieaugis arba nurasymas) laikotarpio metu.
  /// <summary>
  /// Įmonei (leidimui) likęs gavybos kiekis periodo pradžioje
  /// </summary>
  [Column("GAVK_LIKUTIS_PR")]
  public decimal? GAVK_LIKUTIS_PR { get; set; } //GAVK_LIKUTIS_PR->NUMBER(8,3)->Yes->->20->
  [Column("GAVK_LIKUTIS_PB")]
  public decimal? GAVK_LIKUTIS_PB { get; set; } //GAVK_LIKUTIS_PB->NUMBER(8,3)->Yes->->21->
  [Column("GAVK_LIKUTIS_TAME_TARPE_PR")]
  public decimal? GAVK_LIKUTIS_TAME_TARPE_PR { get; set; } //GAVK_LIKUTIS_TAME_TARPE_PR->NUMBER(8,3)->Yes->->22->
  [Column("GAVK_LIKUTIS_TAME_TARPE_PB")]
  public decimal? GAVK_LIKUTIS_TAME_TARPE_PB { get; set; } //GAVK_LIKUTIS_TAME_TARPE_PB->NUMBER(8,3)->Yes->->23->
  [Column("GAVK_IST_TRUMP")] public string? IstekliuRusisID { get; set; } //GAVK_IST_TRUMP->VARCHAR2(10 BYTE)->Yes->->24->
  public IstekliuRusis? IstekliuRusis { get; set; }
  /// <summary>
  /// EPAS sistemos įrašo identifikatorius
  /// </summary>
  //[Column("GAVK_EPAS_ID")] public Int64? GAVK_EPAS_ID { get; set; } //GAVK_EPAS_ID->NUMBER(38,0)->Yes->->25->EPAS sistemos įrašo identifikatorius
}