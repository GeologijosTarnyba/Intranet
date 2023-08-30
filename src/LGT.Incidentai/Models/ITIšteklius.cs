namespace LGT.Incidentai.Models;
public class ITIšteklius : IIDed<string>
{
  public string ID { get; set; }

  public string Name { get; set; }
  public ITIštekliausTipas Tipas { get; set;}
  /// <summary>
  /// RTO – Minimalių paslaugų atstatymo laiko intervalas (angl. Recovery Time Objective)
  /// </summary>
  public decimal RTO { get; set; }
}
public class ITIštekliausTipas : IIDed<string>
{
  public string ID { get; set; }
  public string Name { get; set; }

  public ICollection<ITIšteklius> Instances { get; set; }
}