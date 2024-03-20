using Microsoft.AspNetCore.Components;
namespace LGT.Intranet.Components.In.Shared;
public abstract class CreateClass<TCore> : ComponentBase
  where TCore : class
{
  [Parameter] public string? ParamButtonText { get; set; }
  [Parameter] public EventCallback<TCore> CallbackOnCreate { get; set; }

  override protected async Task OnParametersSetAsync()
  {
    await base.OnParametersSetAsync();
    this.Core = ConstructCore();
  }
  protected TCore? Core { get; set; }
  protected abstract TCore? ConstructCore();
  protected async Task HandleValidSubmit(LGT.Intranet.IntranetContext db)
  {
    if (this.Core == null)
      return;
    db.Add(this.Core);
    await db.SaveChangesAsync();
    db.ChangeTracker.Clear();
    await this.CallbackOnCreate.InvokeAsync(this.Core);
  }
}
