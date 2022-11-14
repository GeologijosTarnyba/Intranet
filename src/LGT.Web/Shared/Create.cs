using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace LGT.Web.Shared;
public class Create<TCore> : ComponentBase
{
  [Parameter] public Func<TCore>? ParamModelGenerator { get; set; }
  [Parameter] public EventCallback<TCore> callbackOnCreate { get; set; }
  override protected async Task OnParametersSetAsync()
  {
    await base.OnParametersSetAsync();
    InitializeData();
  }
  protected EditContext? EditContext;
  protected TCore? model;

  private void InitializeData()
  {
    if (ParamModelGenerator != null)
    {
      this.model = this.ParamModelGenerator.Invoke();
      if(this.model == null)
      {
        this.EditContext = null;
        return;
      } else
      {
        this.EditContext = new EditContext(this.model);
        this.EditContext.OnFieldChanged += EditContext_OnFieldChanged;

      }
    }
  }
  private void EditContext_OnFieldChanged(object? sender, FieldChangedEventArgs e)
  {
    //if (e.FieldIdentifier.FieldName == "Pet")
    //{
    //  model.Name = value.Pet;
    //}
  }
  protected async Task OnCreate()
  {
    var x = this.callbackOnCreate.InvokeAsync(this.model!);
    InitializeData();
    await x;
  }
}
