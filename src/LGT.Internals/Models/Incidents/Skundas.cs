using LGT.Internals.Models.Kontaktai;

namespace LGT.Internals.Models.Incidents;
public class Skundas : IIDed<int>
{
  public int ID { get; set; }
  public SkundasType? Type { get; set; } [Column("TypeID")] public int? TypeID { get; set; }

  public Darbuotojas? Darbuotojas { get ; set; } public int? DarbuotojasID { get ; set; }
  public Asmuo? Asmuo { get ; set; } public int? AsmuoID { get; set; }
  [MaxLength(255)]
  public string? Asmuo_FreeForm { get; set; }

  public DateTime? CreatedAt { get; set; }
  public DateTime? At { get; set; }
  [Required(ErrorMessage = "'{0}' laukas privalomas.")]
  [MaxLength(2000)]
  [Display(Name = "Aprašymas")]
  public string? Markdown { get; set; }

  public Incidentas? Incidentas { get; set; } public int? IncidentasID { get; set; }
}
