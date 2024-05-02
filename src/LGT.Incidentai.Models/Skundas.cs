namespace LGT.Incidentai.Models;
public class Skundas: IIded<int>
{
  public int ID { get; set; }
  public SkundasType? Type { get; set; } [Column("TypeID")] public int? TypeID { get; set; }

  public Kontaktai.Darbuotojas? Darbuotojas { get ; set; } public int? DarbuotojasID { get ; set; }
  public Kontaktai.Asmuo? Asmuo { get ; set; } public int? AsmuoID { get; set; }
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
