namespace LGT.Incidentai.Models;
public class IncidentoPozymis
{
  public int ID { get; set; }
  [MaxLength(255)]
  public string Name { get; set; } = default!;
}
