namespace LGT.Core.Inv;
[Table(name: "LGT_DUOMENU_RINKINIAI", Schema = "INV")]
public class LGT_DUOMENU_RINKINIAI
{
  [NotMapped] // TODO: Map
  [Column("LGTD_TRUMP")]
  public string LGTD_TRUMP { get; set; } //LGTD_TRUMP->VARCHAR2(10 BYTE)->No->->1->
  [NotMapped] // TODO: Map
  [Column("LGTD_PAVADINIMAS")]
  public string LGTD_PAVADINIMAS { get; set; } //LGTD_PAVADINIMAS->VARCHAR2(200 BYTE)->No->->2->
  [NotMapped] // TODO: Map
  [Column("LGTD_PASTABA")]
  public string? LGTD_PASTABA { get; set; } //LGTD_PASTABA->VARCHAR2(250 BYTE)->Yes->->3->
  [NotMapped] // TODO: Map
  [Column("LGTD_AU_DATA")]
  public DateTime? LGTD_AU_DATA { get; set; } //LGTD_AU_DATA->DATE->Yes->->4->
  [NotMapped] // TODO: Map
  [Column("LGTD_AU_VARTOTOJAS")]
  public string? LGTD_AU_VARTOTOJAS { get; set; } //LGTD_AU_VARTOTOJAS->VARCHAR2(30 BYTE)->Yes->->5->
}