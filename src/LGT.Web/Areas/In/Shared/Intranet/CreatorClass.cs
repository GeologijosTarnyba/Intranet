using Microsoft.AspNetCore.Components;
namespace LGT.Web.Areas.In.Shared.Intranet;

public abstract class CreatorClass<TCore>: ComponentBase
  where TCore: class
{
  [Parameter] public string? ParamButtonText { get; set; }
  [Parameter] public EventCallback<TCore> CallbackOnCreate { get; set; }

  protected abstract bool HasRequiredData();
  protected abstract TCore? ConstructCore();

  protected async Task Create(Data.IntranetContext db)
  {
    if (!HasRequiredData())
      return;
    var core = ConstructCore();
    if (core == null)
      return;
    db.Add(core);
    await db.SaveChangesAsync();
    await this.CallbackOnCreate.InvokeAsync(core);
    db.ChangeTracker.Clear();
  }
}