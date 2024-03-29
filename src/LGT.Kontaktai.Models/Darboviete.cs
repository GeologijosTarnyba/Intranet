namespace LGT.Kontaktai.Models;
public class Darboviete
{
  public override string ToString() => this.Name!;
  [MaxLength(32)]
  public string Id { get; set; } = default!;
  [MaxLength(255)]
  [Required]
  public string? Name { get; set; }

  public int? OrderWeight { get; set; }

  public List<Padalinys> Padaliniai { get; set; } = [];
  public List<Etatas> Etatai { get; set; } = [];
  public ICollection<Darbuotojas>? DarbuotojasAssignments { get; set; }
}
