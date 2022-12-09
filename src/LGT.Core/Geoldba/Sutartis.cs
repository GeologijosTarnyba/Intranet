namespace LGT.Core.Geoldba;
[Table(name: "SUTARTYS", Schema = "GEOLDBA")]
public class Sutartis
{
  public ICollection<SutartiesSalyga> Salygos { get; set; }
  public ICollection<ZGRLGavybosObjektas> ZGRLGavybosObjektai { get; set; }
  
  [Key][Column(name: "SUT_ID")] public int ID { get; set; }
  [Column(name: "SUT_LEID_ID")] public int LeidimasID { get; set; }
  public Leidimas Leidimas { get; set; }
  [Column(name: "SUT_NUMERIS")] public int LeidimasIndex { get; set; }
  /// <summary>
  /// Sutarties sudarymo data
  /// </summary>
  [Column(name: "SUT_SUDARYMO_DATA")]
  public DateTime Since { get; set; } //SUT_SUDARYMO_DATA->DATE->No->->4->
  /// <summary>
  /// Nurodo iki kada galioja sutartis
  /// </summary>
  [Column(name: "SUT_GALIOJA_IKI")]
  public DateTime Until { get; set; } //SUT_GALIOJA_IKI->DATE->No->->5->
}