namespace LGT.Geolis.Geoldba;
[Table(name: "GREZINIO_PRIKL_TELK", Schema = "GEOLDBA")]
public class GREZINIO_PRIKL_TELK
{
  [Key]
  [Column("GPT_ID")]
  public Int64 ID { get; set; } //GPT_ID->NUMBER(10,0)->No->->1->
  /// <summary>
  /// Gręžiniui suteiktas unikalus numeris, pirminis raktas
  /// </summary>
  [Column("GPT_GR_NR")]
  public int GrezinysID { get; set; } //GPT_GR_NR->NUMBER(6,0)->No->->2->Gręžiniui suteiktas unikalus numeris, pirminis raktas
  [Required] public Grezinys? Grezinys { get; set; }
  [Column("GPT_TELK_KODAS")]
  public int TelkinysID { get; set; } //GPT_TELK_KODAS->NUMBER(5,0)->No->->3->
  [Required] public Telkinys? Telkinys { get; set; }
  // // TODO: Map
  //[Column("GPT_VARTOTOJAS")]
  //public string? GPT_VARTOTOJAS { get; set; } //GPT_VARTOTOJAS->VARCHAR2(30 BYTE)->Yes->->4->
  // // TODO: Map
  //[Column("GPT_DATA")]
  //public DateTime? GPT_DATA { get; set; } //GPT_DATA->DATE->Yes->->5->
  ///// <summary>
  ///// EPAS sistemos įrašo identifikatorius
  ///// </summary>
  // // TODO: Map
  //[Column("GPT_EPAS_ID")]
  //public Int64? GPT_EPAS_ID { get; set; } //GPT_EPAS_ID->NUMBER(38,0)->Yes->->6->EPAS sistemos įrašo identifikatorius
}
