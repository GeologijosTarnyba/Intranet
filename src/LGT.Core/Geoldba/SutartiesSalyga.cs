namespace LGT.Core.Geoldba;
[Table(name: "SUTARTIES_SALYGOS", Schema = "GEOLDBA")]
public class SutartiesSalyga
{
  [Column("STS_SUT_ID")]
  public int SutartisID { get; set; } //STS_SUT_ID->NUMBER(5,0)->No->->1->
  public Sutartis Sutartis { get; set; }
  [Column("STS_EIL_NR")]
  public int SutartisIndex { get; set; } //STS_EIL_NR->NUMBER(3,0)->No->->2->
  [Column("STS_SST_KOD")]
  public int SalygosTipasID { get; set; } //STS_SST_KOD->NUMBER(5,0)->No->->3->
  public SalygosTipas SalygosTipas { get; set; }
  [Column("STS_SALYGA")]
  public string Name { get; set; } //STS_SALYGA->VARCHAR2(2000 BYTE)->No->->4->
  //[Column("STS_ATLIKTI_IKI")]public DateTime? STS_ATLIKTI_IKI { get; set; } //STS_ATLIKTI_IKI->DATE->Yes->->5->
  //[Column("STS_ATLIKTA")]public string? STS_ATLIKTA { get; set; } //STS_ATLIKTA->VARCHAR2(1 BYTE)->Yes->->6->
  //[Column("STS_DATA")]public DateTime? STS_DATA { get; set; } //STS_DATA->DATE->Yes->->7->
  //[Column("STS_ALIS_ID")]public int? STS_ALIS_ID { get; set; } //STS_ALIS_ID->NUMBER(10,0)->Yes->->8->
}