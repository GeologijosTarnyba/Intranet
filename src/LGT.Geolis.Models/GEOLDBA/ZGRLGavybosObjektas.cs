namespace LGT.Geolis.Geoldba;
/// <summary>
/// ŽGR Leidimo gavybos objektas
/// </summary>
[Table(name: "ZGRL_GAVYBOS_OBJEKTAI", Schema = "GEOLDBA")]
public class ZGRLGavybosObjektas
{
  [Key]
  [Column(name: "ZGGO_ID")]
  public int ID { get; set; } //ZGGO_ID->NUMBER(10,0)->No->->1->
  [Column(name: "ZGGO_SUT_ID")] public int SutartisID { get; set; } //ZGGO_SUT_ID->NUMBER(5,0)->No->->2->
  [Required] public Sutartis? Sutartis { get; set; }
  [Column(name: "ZGGO_GR_NR")] public int? GrezinysID { get; set; } //ZGGO_GR_NR->NUMBER(6,0)->Yes->->3->Gręžiniui suteiktas unikalus numeris, pirminis raktas
  public Grezinys? Grezinys { get; set; }
  [Column(name: "ZGGO_IR_TRUMP")] public string IstekliuRusisID { get; set; } = default!; //ZGGO_IR_TRUMP->VARCHAR2(10 BYTE)->No->->4->
	[Required] public IstekliuRusis? IstekliuRusis { get; set; }
  [Column(name: "ZGGO_TELK_KODAS")] public int? TelkinysID { get; set; } //ZGGO_TELK_KODAS->NUMBER(5,0)->Yes->->5->
  public Telkinys? Telkinys { get; set; }
  [Column(name: "ZGGO_GSKL_KODAS")] public int? GavybosSklypasID { get; set; } //ZGGO_GSKL_KODAS->NUMBER(6,0)->Yes->->6->Unikalus aut. gener. kodas, skirtas ry?iui su grafiniu vaizdu.
  public GavybosSklypas? GavybosSklypas { get; set; }
  //[Column(name: "ZGGO_PLANO_DATA")] public DateTime? ZGGO_PLANO_DATA { get; set; } //ZGGO_PLANO_DATA->DATE->Yes->->7->
  //[Column(name: "ZGGO_PLANO_NR")] public string? ZGGO_PLANO_NR { get; set; } //ZGGO_PLANO_NR->VARCHAR2(100 BYTE)->Yes->->8->
}
