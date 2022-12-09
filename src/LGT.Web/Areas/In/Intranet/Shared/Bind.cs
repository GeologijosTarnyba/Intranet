using Microsoft.AspNetCore.Components;
namespace LGT.Web.Areas.In.Intranet.Shared;
public abstract class Bind<TCore>: ComponentBase
  where TCore : class
{
  [Parameter] public TCore value { get; set; }
  [Parameter] public EventCallback<TCore> valueChanged { get; set; }
  [Parameter] public EventCallback CallbackOnValidSubmit { get; set; }
  [Parameter] public string? ParamButtonText { get; set; }
}