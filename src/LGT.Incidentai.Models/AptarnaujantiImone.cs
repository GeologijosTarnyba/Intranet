namespace LGT.Incidentai.Models;
public class AptarnaujantiImone: IIded<string>
{
  public override string ToString() => this.Name!;
  [MaxLength(32)]
  public string ID { get; set; } = default!;
  [MaxLength(255)]
  [Required]
  public string? Name { get; set; }
  public bool IsActive { get; set; }
  public ICollection<Kreipinys>? Krepiniai { get; set; }
  public ICollection<AptarnavimoSutartis>? Sutartys { get; set; }
}
