namespace LGT.Internals.Models.Incidents;
public class IncidentoPozymis : IIDed<int>
{
  public int ID { get; set; }
  [MaxLength(255)]
  public string Name { get; set; }
}
