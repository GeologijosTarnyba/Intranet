namespace LGT.Core;
public interface IIDed<TKey>
{
  public TKey ID { get; set; }
}