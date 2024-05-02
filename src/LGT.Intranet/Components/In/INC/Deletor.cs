using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;

namespace LGT.Intranet.Components.In.INC;
using LGT.Incidentai;
public abstract class Deletor<TModel, TKey>: Or
  where TModel : class, IIded<TKey>
{
  [Parameter] public TKey Id { get; set; } = default!;

  protected virtual IQueryable<TModel> Includer(IQueryable<TModel> dbset) => dbset;
  private IQueryable<TModel> Q => this.db
    .Set<TModel>()
    .Where(item => item.ID!.Equals(this.Id))
  ;
  protected async Task DoDelete()
  {
    await this.Q.ExecuteDeleteAsync();
    //this.model = await this.Q.FirstOrDefaultAsync();
    //if (model == null)
    //  return;
    //db.Remove(model);
    //await db.SaveChangesAsync();
    await OnAfterSave();
  }
  [Inject] IJSRuntime JSRuntime { get; set; } = default!;
  protected virtual async Task OnAfterSave()
  {
    await JSRuntime.InvokeVoidAsync("history.back");
  }
}
