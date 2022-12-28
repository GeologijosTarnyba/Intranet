namespace LGT.Core.Geoldba;
/// <summary>
/// Telkinio sluoksniai. Išskiriami pagal išteklių išžvalgymo kategoriją, išteklių kokybės parametrus.
/// </summary>
[Table(name: "APIB_GEOL_SL", Schema = "GEOLDBA")]
public class TelkinioSluoksnis
{

  public ICollection<GIS_ISTEKLIU_PLOTAI> GIS_ISTEKLIU_PLOTAI { get; set; }
  public ICollection<TelkinioSluoksnioTyrimas> Tyrimai { get; set; }
  public ICollection<NER_GAV_KETV> NER_GAV_KETVs { get; set; }
  public ICollection<IstekliuPanaudojimas> IstekliuPanaudojimai { get; set; }
  public ICollection<Isteklis> Istekliai { get; set; }
  [Key]
  [Column("AGS_SL_NR")] 
  public int ID { get; set; } //AGS_SL_NR->NUMBER(6,0)->No->->1->Unikalus, automatiškai generuojamas kodas.
  [Column("AGS_TELK_KODAS")]
  public int TelkinysID { get; set; } //AGS_TELK_KODAS->NUMBER(5,0)->No->->2->Unikalus, aut. gen. kodas, skirtas ry?iui su grafika.
  public Telkinys Telkinys { get; set; }
  [Column("AGS_EILES_NR")]
  public Int64 TelkinysIndex { get; set; } //AGS_EILES_NR->NUMBER(2,0)->No->->3->Sluoksnio eil?s numeris telkinyje.
  [Column("AGS_AST_TRUMP")]
  public string TipasID { get; set; } //AGS_AST_TRUMP->VARCHAR2(10 BYTE)->No->->4->Sutrumpintas sluoksnio tipo pavadinimas.
  public TelkinioSluoksnioTipas Tipas { get; set; }
  /// <summary>
  /// Sluoksnio slūgsojimo kraigo galima didžiausia reikšmė
  /// </summary>
  [Column("AGS_KRAIGAS_IKI")]
  public decimal? AGS_KRAIGAS_IKI { get; set; } //AGS_KRAIGAS_IKI->NUMBER(6,2)->Yes->->5->Sluoksnio slūgsojimo kraigo galima didžiausia reikšmė.
  /// <summary>
  /// Sluoksnio slūgsojimo pado galima didžiausia reikšmė
  /// </summary>
  [Column("AGS_PADAS_IKI")]
  public decimal? AGS_PADAS_IKI { get; set; } //AGS_PADAS_IKI->NUMBER(6,2)->Yes->->6->Sluoksnio slūgsojimo pado galima didžiausia reikšmė.
  /// <summary>
  /// Sluoksnio storio galima didžiausia reikšmė.
  /// </summary>
  [Column("AGS_STORIS_IKI")]
  public decimal? AGS_STORIS_IKI { get; set; } //AGS_STORIS_IKI->NUMBER(6,2)->Yes->->7->Sluoksnio storio galima didžiausia reikšmė.
  /// <summary>
  /// Sluoksnio litologinis aprašymas
  /// </summary>
  [Column("AGS_APRASYMAS")]
  public string? AGS_APRASYMAS { get; set; } //AGS_APRASYMAS->VARCHAR2(200 BYTE)->Yes->->8->Sluoksnio litologinis aprašymas
  /// <summary>
  /// Sluoksnio slūgsojimo kraigo galima mažiausia reikšmė.
  /// </summary>
  [Column("AGS_KRAIGAS_NUO")]
  public decimal? AGS_KRAIGAS_NUO { get; set; } //AGS_KRAIGAS_NUO->NUMBER(6,2)->Yes->->9->Sluoksnio slūgsojimo kraigo galima mažiausia reikšmė.
  /// <summary>
  /// Sluoksnio slūgsojimo pado galima mažiausia reikšmė.
  /// </summary>
  [Column("AGS_PADAS_NUO")]
  public decimal? AGS_PADAS_NUO { get; set; } //AGS_PADAS_NUO->NUMBER(6,2)->Yes->->10->Sluoksnio slūgsojimo pado galima mažiausia reikšmė.
  /// <summary>
  /// Sluoksnio storio galima mažiausia reikšmė.
  /// </summary>
  [Column("AGS_STORIS_NUO")]
  public decimal? AGS_STORIS_NUO { get; set; } //AGS_STORIS_NUO->NUMBER(6,2)->Yes->->11->Sluoksnio storio galima mažiausia reikšmė.
  /// <summary>
  /// Sluoksnio padėtis telkinyje (pvz.: šiaurė, pietryčiai).
  /// </summary>
  [Column("AGS_PADETIS")]
  public string? AGS_PADETIS { get; set; } //AGS_PADETIS->VARCHAR2(300 BYTE)->Yes->->12->Sluoksnio padėtis telkinyje (pvz.: šiaurė, pietryčiai).
  // TODO: uncomment
  ///// <summary>
  ///// Unikalus, automatiškai generuojamas kodas.
  ///// </summary>
  //[Column("AGS_AGS_SL_NR")]
  //public Int64? AGS_AGS_SL_NR { get; set; } //AGS_AGS_SL_NR->NUMBER(6,0)->Yes->->13->Unikalus, automatiškai generuojamas kodas.
  /// <summary>
  /// Sluoksnio geologinis indeksas.
  /// </summary>
  [Column("AGS_GEOL_IND")]
  public string? AGS_GEOL_IND { get; set; } //AGS_GEOL_IND->VARCHAR2(100 BYTE)->Yes->->14->Sluoksnio geologinis indeksas.
  /// <summary>
  /// Vidutinis sluoksnio storis
  /// </summary>w
  [Column("AGS_STORIS_VID")]
  public decimal? AGS_STORIS_VID { get; set; } //AGS_STORIS_VID->NUMBER(6,2)->Yes->->15->Vidutinis sluoksnio storis
  /// <summary>
  /// Patvirtintas ištekliu plotas (ataskaita)
  /// </summary>
  [Column("AGS_PLOTAS")]
  public decimal? AGS_PLOTAS { get; set; } //AGS_PLOTAS->NUMBER(6,2)->Yes->->16->Patvirtintas ištekliu plotas (ataskaita)
  /// <summary>
  /// Paskutines sluoksnio buklės fiksavimo data
  /// </summary>
  [Column("AGS_DATA_NUO")]
  public DateTime? AGS_DATA_NUO { get; set; } //AGS_DATA_NUO->DATE->Yes->->17->Paskutines sluoksnio buklės fiksavimo data
  /// <summary>
  /// Sluoksnio technine bukle
  /// </summary>
  [Column("AGS_TBUK_SUTR")]
  public string? AGS_TBUK_SUTR { get; set; } //AGS_TBUK_SUTR->CHAR(10 BYTE)->Yes->->18->Sluoksnio technine bukle
  /// <summary>
  /// Ataskaitoje patvirtintas Išteklių plotas
  /// </summary>
  [Column("AGS_PLOTAS_ATS")]
  public decimal? AGS_PLOTAS_ATS { get; set; } //AGS_PLOTAS_ATS->NUMBER(6,2)->Yes->->19->Ataskaitoje patvirtintas Išteklių plotas
  /// <summary>
  /// Išteklių plotas, paskaiciuotas pagal ribinius taškus
  /// </summary>
  [Column("AGS_PLOTAS_APSK")]
  public decimal? AGS_PLOTAS_APSK { get; set; } //AGS_PLOTAS_APSK->NUMBER(6,2)->Yes->->20->Išteklių plotas, paskaiciuotas pagal ribinius taškus
  [Column("AGS_VGR_KODAS")]
  public string? AGS_VGR_KODAS { get; set; } //AGS_VGR_KODAS->VARCHAR2(10 BYTE)->Yes->->21->
  [Column("AGS_IST_TRUMP")]
  public string? AGS_IST_TRUMP { get; set; } //AGS_IST_TRUMP->VARCHAR2(10 BYTE)->Yes->->22->
  [Column("AGS_KONF_PABAIGA")]
  public DateTime? AGS_KONF_PABAIGA { get; set; } //AGS_KONF_PABAIGA->DATE->Yes->->23->
  [Column("AGS_KOEF_TM")]
  public decimal? AGS_KOEF_TM { get; set; } //AGS_KOEF_TM->NUMBER(11,9)->Yes->->24->
  [Column("AGS_KOEF_MT")]
  public decimal? AGS_KOEF_MT { get; set; } //AGS_KOEF_MT->NUMBER(11,9)->Yes->->25->
  [Column("AGS_GYDYM")]
  public string? AGS_GYDYM { get; set; } //AGS_GYDYM->VARCHAR2(1 BYTE)->Yes->->26->
  [Column("AGS_PNS_KODAS")]
  public string? AGS_PNS_KODAS { get; set; } //AGS_PNS_KODAS->VARCHAR2(10 BYTE)->Yes->->27->

  public override string ToString()
  {
    return $"{this.ID}";

  }
}
