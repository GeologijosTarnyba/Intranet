namespace LGT.Kontaktai.Models;
public class EtatasName
{
  public override string? ToString() => this.Vardininkas;
  [Key]
  public string Id { get; set; } = string.Empty;
  public int? Weight { get; set; }
  public string? Vardininkas { get; set; }
  public string? Vardininke { get; set; }
  public string? Kilmininkas { get; set; }
  public string? Kilmininke { get; set; }
}
