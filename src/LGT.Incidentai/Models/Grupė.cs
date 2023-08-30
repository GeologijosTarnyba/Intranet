namespace LGT.Incidentai.Models;
public class Grupė : IIDed<int>
{
  public int ID { get; set; }
  public string Name { get; set; }

  public ICollection<Pogrupis> Things { get; set; }
}
