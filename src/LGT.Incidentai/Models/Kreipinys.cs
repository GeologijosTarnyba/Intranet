using LGT.Core;
namespace LGT.Incidentai.Models;
public class Kreipinys : IIDed<int>
{
  public int ID { get; set; }

  public ICollection<CommentT<Incidentas>> Comments { get; set; }
}
