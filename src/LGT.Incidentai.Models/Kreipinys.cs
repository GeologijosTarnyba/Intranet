namespace LGT.Incidentai.Models;
public class Kreipinys
{
  [Required] public AptarnaujantiImone? AptarnaujantiImone { get; set; }
  [MaxLength(32)] public string AptarnaujantiImoneID { get; set; } = default!;
  
  public int ID { get; set; }
  public DateTime? CreatedAt { get; set; }

  [Column("Krepinys")] public string? UName { get; set; }
  [Column("Nuoroda")] public string? Link { get; set; }

  public Incidentas? Incidentas { get; set; } public int? IncidentasID { get; set; }
  [MaxLength(1000)] public string? RequestText { get; set; }
  [MaxLength(1000)] public string? SolutionText { get; set; }
  [Column("Nuo")] public DateTime? Since { get; set; }
  [Column("Iki")] public DateTime? Until { get; set; }

  public ICollection<Sprendimas>? Sprendimai { get; set; }
}
