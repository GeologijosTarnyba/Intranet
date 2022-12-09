namespace LGT.Core.Geoldba;
[Table(name: "GAVSKL_PROJEKTAI", Schema = "GEOLDBA")]
public class GavybosSklypoProjektas
{
  [NotMapped]
  [Column("GSKP_GSKL_KODAS")]
  public Int64 GSKP_GSKL_KODAS { get; set; } //GSKP_GSKL_KODAS->NUMBER(6,0)->No->->1->
  [NotMapped]
  [Column("GSKP_DATA_IKI")]
  public DateTime? GSKP_DATA_IKI { get; set; } //GSKP_DATA_IKI->DATE->Yes->->2->
  [NotMapped]
  [Column("GSKP_PROJ_DATA")]
  public DateTime? GSKP_PROJ_DATA { get; set; } //GSKP_PROJ_DATA->DATE->Yes->->3->
  [NotMapped]
  [Column("GSKP_PASTABA")]
  public string? GSKP_PASTABA { get; set; } //GSKP_PASTABA->VARCHAR2(250 BYTE)->Yes->->4->
  [NotMapped]
  [Column("GSKP_LEID_ID")]
  public Int64? GSKP_LEID_ID { get; set; } //GSKP_LEID_ID->NUMBER(6,0)->Yes->->5->
}