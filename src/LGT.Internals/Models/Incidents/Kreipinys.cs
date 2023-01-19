using LGT.Internals.Models.Kontaktai;
namespace LGT.Internals.Models.Incidents;
public class Kreipinys : IIDed<int>
{
  public Darboviete Darboviete { get; set; } 
  public string DarbovieteID { get; set; }
  public int ID { get; set; }
  public DateTime? CreatedAt { get; set; } = DateTime.Now;

  [Column("Krepinys")] public string? UName { get; set; }
  [Column("Nuoroda")] public string? Link { get; set; }

  public Incidentas Incidentas { get; set; } [Required] public int? IncidentasID { get; set; }
  [MaxLength(1000)] public string? SolutionText { get; set; }

  public DateTime? Since { get; set; }
  public DateTime? Until { get; set; }

  public ICollection<Sprendimas> Sprendimai { get; set; }
}
