namespace LGT.Geolis.Geoldba;
[Table(name: "SALYGU_TIPAI", Schema = "GEOLDBA")]
public class SalygosTipas
{
  [Key]
  [Column("SST_KOD")]
  public int ID { get; set; } //SST_KOD->NUMBER(5,0)->No->->1->
  [Column("SST_TIPAS")]
  public string Name { get; set; } = default!; //SST_TIPAS->VARCHAR2(100 BYTE)->No->->2->
	[NotMapped]
  [Column("SST_GRUPE")]
  public string? GroupName { get; set; } //SST_GRUPE->VARCHAR2(10 BYTE)->Yes->->3->
  [NotMapped]
  [Column("SST_EILNR")]
  public int? GroupIndex { get; set; } //SST_EILNR->NUMBER(5,0)->Yes->->4->
  [Column("SST_DATA_IKI")]
  public DateTime? Until { get; set; } //SST_DATA_IKI->DATE->Yes->->5->
}
