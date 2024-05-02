using LGT.Incidentai;

using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace LGT.Intranet.Components.In.INC;

public abstract class Editor<TModel, TKey>: Or
  where TModel : class, IIded<TKey>
{
  [Parameter] public TKey Id { get; set; } = default!;
  [Inject] protected NavigationManager NavigationManager { get; set; } = default!;
  protected TModel? model;
  private IQueryable<TModel> Q => this.db
    .Set<TModel>()
    .Where(item => item.ID!.Equals(this.Id))
  ;
  override protected async Task OnParametersSetAsync()
  {
    await base.OnParametersSetAsync();
    this.model = await this.Includer(Q).FirstOrDefaultAsync();
  }
  protected virtual IQueryable<TModel> Includer(IQueryable<TModel> dbset) => dbset;
  protected async Task DoUpdate()
  {
    await db.SaveChangesAsync();
    this.OnAfterSave();
  }
  protected abstract void OnAfterSave();
}
//<EditForm Model=@this.model OnValidSubmit=@this.DoUpdate>
//  <DataAnnotationsValidator />
//  <FluentValidationSummary />
//  <FluentStack Orientation="@Orientation.Vertical">
//    <div>
//    </div>
//    <FluentButton Type=@ButtonType.Submit Appearance=@Appearance.Accent>Save</FluentButton>
//  </FluentStack>
//</EditForm>
