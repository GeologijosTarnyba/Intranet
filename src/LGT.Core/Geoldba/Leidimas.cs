namespace LGT.Core.Geoldba;
[Table(name: "LEIDIMAI", Schema = "GEOLDBA")]
public class Leidimas
{
  #region Views
  //public ICollection<Views.W_ZGR_MARKSEID_PLANAI> W_ZGR_MARKSEID_PLANAI { get; set; }
  #endregion
  public ICollection<Sutartis> Sutartys { get; set; }
  public static System.Linq.Expressions.Expression<Func<Leidimas, bool>> Galioja
  {
    get
    {
      return item => 
           (item.IsdavesJuridinisAsmuoID == 11) // Išdavė LGT
        && (item.DataPanaikinimo == null || item.DataPanaikinimo.Value > DateTime.Now)  // Nepanaikintas
        && (item.DataIki == null || item.DataIki >= DateTime.Now) // nenurodyta iki kada galioja arba nurodyta ir dar galioja
      ;
    }
  }

  [Key][Column(name: "LEID_ID")]
  public int ID { get; set; } //LEID_ID->NUMBER(5,0)->No->->1->
  [Column(name: "LEID_NR")]
  public string Name { get; set; } //LEID_NR->VARCHAR2(15 BYTE)->No->->2->
  //[Column(name: "LEID_DOKR_SUTR")] public string LEID_DOKR_SUTR { get; set; } //LEID_DOKR_SUTR->VARCHAR2(10 BYTE)->No->->3->
  [Column(name: "LEID_ISDAVIMO_DATA")]
  public DateTime LEID_ISDAVIMO_DATA { get; set; } //LEID_ISDAVIMO_DATA->DATE->No->->4->
  //[Column(name: "LEID_ISB_TRUMP")] public string LEID_ISB_TRUMP { get; set; } //LEID_ISB_TRUMP->VARCHAR2(3 BYTE)->No->->5->
  [Column(name: "LEID_ORGIM_KOD")]
  public int? Kam_JuridinisAsmuoID { get; set; }
  public JuridinisAsmuo? Kam_JuridinisAsmuo { get; set; }
  [Column(name: "LEID_JVS_ID")] public int? KAM_JungtinesVeiklosSutartisID { get; set; }
  public JungtinesVeiklosSutartis KAM_JungtinesVeiklosSutartis { get; set; }
  [Column(name: "LEID_ASM_ID")] public int? Kam_FizinisAsmuoID { get; set; }
  public Asmuo Kam_FizinisAsmuo { get; set; }

  [Column(name: "LEID_OI_ISDAVE")] 
  public int IsdavesJuridinisAsmuoID { get; set; } //LEID_OI_ISDAVE->NUMBER(5,0)->No->->7->- Column already exists
  public JuridinisAsmuo IsdavesJuridinisAsmuo { get; set; }
  [Column(name: "LEID_DATA_NUO")]
  public DateTime DataNuo { get; set; } //LEID_DATA_NUO->DATE->No->->8->
  [Column(name: "LEID_DATA_IKI")]
  public DateTime? DataIki { get; set; } //LEID_DATA_IKI->DATE->Yes->->9->
  [Column(name: "LEID_PAN_NUO")]
  public DateTime? DataPanaikinimo { get; set; } //LEID_PAN_NUO->DATE->Yes->->10->
  [Column(name: "LEID_PAN_PRIEZASTIS")]
  public string? Ended_Reason { get; set; } //LEID_PAN_PRIEZASTIS->VARCHAR2(1000 BYTE)->Yes->->11->
  //[Column(name: "LEID_STOP_NUO")]public DateTime? LEID_STOP_NUO { get; set; } //LEID_STOP_NUO->DATE->Yes->->12->
  //[Column(name: "LEID_BUV_ID")] public int? LEID_BUV_ID { get; set; } //LEID_BUV_ID->NUMBER(5,0)->Yes->->13->
  //[Column(name: "LEID_PRAS_ID")]public int? LEID_PRAS_ID { get; set; } //LEID_PRAS_ID->NUMBER(5,0)->Yes->->14->
  //[Column(name: "LEID_PAV")]public string? LEID_PAV { get; set; } //LEID_PAV->VARCHAR2(255 BYTE)->Yes->->15->
  //[Column(name: "LEID_ALIS_ID")] public string? LEID_ALIS_ID { get; set; } //LEID_ALIS_ID->VARCHAR2(20 BYTE)->Yes->->18->
  //[Column(name: "LEID_DATA_PAKEIT")]public DateTime? LEID_DATA_PAKEIT { get; set; } //LEID_DATA_PAKEIT->DATE->Yes->->19->
}