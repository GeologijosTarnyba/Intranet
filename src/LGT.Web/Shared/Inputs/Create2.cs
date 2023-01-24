using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace L2Tools.Blazor.Shared.Inputs;
public class Create2<TCore, TDatabase> : ComponentBase
  where TDatabase : DbContext
{
  [Inject] protected TDatabase db { get; set; }
  [Parameter] public Func<TCore?, TCore>? ParamInit { get; set; }
  [Parameter] public EventCallback<TCore> callbackOnCreate { get; set; }
  override protected async Task OnParametersSetAsync()
  {
    await base.OnParametersSetAsync();
    InitializeData();
  }
  protected TCore? model;

  private void InitializeData()
  {
    if (ParamInit != null)
    {
      model = ParamInit.Invoke(model);
    }
  }
  protected async Task DoCreate()
  {
    if (model == null)
    {
      return;
    }
    try
    {

      db.Add(model);
      await db.SaveChangesAsync();
    }
    catch (Exception e)
    {
      Console.WriteLine($"Failed to create {model}. {e.Message}");
    }
    await OnAfterCreate();
  }
  protected async Task OnAfterCreate()
  {
    var x = callbackOnCreate.InvokeAsync(model!);
    InitializeData();
    await x;
  }
}
