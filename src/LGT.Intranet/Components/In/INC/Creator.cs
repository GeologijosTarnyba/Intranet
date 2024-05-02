using Microsoft.AspNetCore.Components;

namespace LGT.Intranet.Components.In.INC;

public abstract class Creator<TModel>: Or
  where TModel : class, new()
{
  protected TModel model = new();
  
  [Inject] protected NavigationManager NavigationManager { get; set; } = default!;
  protected async Task DoCreate()
  {
    await this.OnBeforeSave();
    this.db.Set<TModel>().Add(this.model);
    await db.SaveChangesAsync();
    this.OnAfterSave();
  }
  protected virtual Task OnBeforeSave() { return Task.CompletedTask; }
  protected abstract void OnAfterSave();
}
/*
@inherits Creator<global::Objectify.Models.XXX>
@rendermode InteractiveServer
@page "/o/YYY/c"
@code {
  // [SupplyParameterFromQuery] 
  // public Guid? someId { get; set; }
  override protected async Task OnParametersSetAsync()
  {
    await base.OnParametersSetAsync();
  }
  protected override void OnAfterSave()
  {
    this.NavigationManager.NavigateTo($"/o/YYY/{this.model.Id}");
  }
}
<h3>Create XXX</h3>
<EditForm Model=@this.model OnValidSubmit=@this.DoCreate FormName="create_scope">
  <DataAnnotationsValidator />
  <FluentValidationSummary />
  <FluentStack Orientation=@Orientation.Vertical>
    <div></div>
    <div></div>
    <div></div>
    <div></div>
    <div></div>
    <div></div>
    <FluentButton Type=@ButtonType.Submit Appearance=@Appearance.Accent>Create</FluentButton>
  </FluentStack>
</EditForm>
*/
