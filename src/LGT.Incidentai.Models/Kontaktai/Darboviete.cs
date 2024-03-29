namespace LGT.Incidentai.Models.Kontaktai;
public class Darboviete
{
  public override string ToString() => this.Name!;
  [MaxLength(32)]
  public string ID { get; set; } = default!;
  [MaxLength(255)]
  [Required]
  public string? Name { get; set; }

  public int? OrderWeight { get; set; }

  public ICollection<Darbuotojas>? DarbuotojasAssignments { get; set; }
}
