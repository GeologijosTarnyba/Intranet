using Microsoft.AspNetCore.Components;


namespace LGT.Intranet.Components.In.INC;
using LGT.Incidentai;
public class Detailer<TModel, TKey>: Or
  where TModel : class, IIded<TKey>
{
  [Parameter] public TKey Id { get; set; } = default!;
  protected IQueryable<TModel> Q => this.db.Set<TModel>().Where(item => item.ID!.Equals(this.Id));
}
