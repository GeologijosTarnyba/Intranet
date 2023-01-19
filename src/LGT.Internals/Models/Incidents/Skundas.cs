using LGT.Internals.Models.Kontaktai;

namespace LGT.Internals.Models.Incidents;
public class Skundas : IIDed<int>
{
  public int ID { get; set; }
  public SkundasType? Type { get; set; }

  public Darbuotojas? Darbuotojas { get ; set; } public int? DarbuotojasID { get ; set; }
  public Asmuo? Asmuo { get ; set; } public int? AsmuoID { get; set; }

  [Required]
  public DateTime? CreatedAt { get; set; }
  public DateTime? At { get; set; }
  [MaxLength(2000)]
  public string? Markdown { get; set; }

  public Incidentas? Incidentas { get; set; } public int? IncidentasID { get; set; }
}
