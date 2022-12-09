namespace LGT.Core.Geoldba;
[Table(name: "ISTEKLIU_RUSYS", Schema = "GEOLDBA")]
public class IstekliuRusis
{
  public ICollection<ZGRLGavybosObjektas> ZGRLGavybosObjektai { get; set; }

  [Key][Column(name: "IR_TRUMP")]
  public string ID { get; set; } //IR_TRUMP->VARCHAR2(10 BYTE)->No->->1->
  [Column(name: "IR_PAV")]
  public string Name { get; set; } //IR_PAV->VARCHAR2(50 BYTE)->No->->2->
  [Column(name: "IR_PAV_EN")]
  public string Name_EN { get; set; } //IR_PAV_EN->VARCHAR2(50 BYTE)->No->->7->
  [Column(name: "IR_PAV_KLM")]
  public string Name_Kilmininkas { get; set; } //IR_PAV_KLM->VARCHAR2(50 BYTE)->No->->4->
  [Column(name: "IR_IR_TRUMP")]
  public string? ParentID { get; set; } //IR_IR_TRUMP->VARCHAR2(10 BYTE)->Yes->->3->
  public IstekliuRusis Parent { get; set; }
  public ICollection<IstekliuRusis> Children { get; set; }
  /// <summary>
  /// Reglamentuotas teisės aktais žr. "ŽEMĖS GELMIŲ REGISTRO OBJEKTŲ DUOMENŲ KLASIFIKATORIAI"
  /// </summary>
  [Column(name: "IR_KODAS")]
  public string Kodas { get; set; } //IR_KODAS->VARCHAR2(10 BYTE)->No->->5->
  [Column(name: "IR_MAPX_GRUPE")]
  public string? GroupID { get; set; } //IR_MAPX_GRUPE->VARCHAR2(10 BYTE)->Yes->->6->
  public IštekliųRusisGroup? Group { get; set; }
  /// <summary>
  /// Išteklių rušies galiojimo pabaigos data
  /// </summary>
  [Column(name: "IR_GALIOJA_IKI")]
  public DateTime? Until { get; set; } //IR_GALIOJA_IKI->DATE->Yes->->8->Išteklių rušies galiojimo pabaigos data
}