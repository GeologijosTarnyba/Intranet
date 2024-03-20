using Microsoft.AspNetCore.Components;
namespace LGT.Intranet.Components.In.Shared;
public abstract class Bind<TCore>: ComponentBase
  where TCore : class
{
  [EditorRequired]
  [Parameter] public TCore value { get; set; } = default!;
  [Parameter] public EventCallback<TCore> valueChanged { get; set; }
  [Parameter] public EventCallback CallbackOnValidSubmit { get; set; }
  [Parameter] public string? ParamButtonText { get; set; }
}
