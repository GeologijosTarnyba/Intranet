namespace LGT.Kontaktai.Models;
public class Darboviete
{
  [MaxLength(32)]
  public string ID { get; set; } = default!;
  [MaxLength(255)]
  [Required]
  public string? Name { get; set; }

  public int? OrderWeight { get; set; }

  public ICollection<Darbuotojas>? DarbuotojasAssignments { get; set; }
}
