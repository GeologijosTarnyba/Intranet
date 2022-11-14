namespace LGT.Core;
public class IDed : IIDed<Guid>
{
  public Guid ID { get; set; } = Guid.NewGuid();
}