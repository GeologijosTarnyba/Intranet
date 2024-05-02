namespace LGT.Incidentai.Models;
public class IncidentoPozymis: IIded<int>
{
  public override string ToString() => this.Name;
  public int ID { get; set; }
  [Required]
  [MaxLength(255)]
  public string Name { get; set; } = default!;
}
