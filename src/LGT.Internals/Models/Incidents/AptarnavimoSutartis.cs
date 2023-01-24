namespace LGT.Internals.Models.Incidents;
public class AptarnavimoSutartis : IIDed<int>
{
  public int ID { get ;set; }
  public AptarnaujantiImone AptarnaujantiImone { get; set; } [Required] public string? AptarnaujantiImoneID { get; set; }
  public DateTime? CreatedAt { get; set; }
  [Column("Iki")]
  public DateTime? Since { get; set; }
  [Column("Nuo")]
  public DateTime? Until { get; set; }
}
