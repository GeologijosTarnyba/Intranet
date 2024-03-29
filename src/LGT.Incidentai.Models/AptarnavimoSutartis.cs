namespace LGT.Incidentai.Models;
public class AptarnavimoSutartis
{
  public int ID { get ;set; }
  [Required] public AptarnaujantiImone? AptarnaujantiImone { get; set; }
  public string? AptarnaujantiImoneID { get; set; }
  public DateTime? CreatedAt { get; set; }
  [Column("Iki")]
  public DateTime? Since { get; set; }
  [Column("Nuo")]
  public DateTime? Until { get; set; }
}
