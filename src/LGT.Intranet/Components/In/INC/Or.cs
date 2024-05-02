using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace LGT.Intranet.Components.In.INC;

public class Or: ComponentBase
{
  #pragma warning disable IDE1006 // Naming Styles
  [Inject] protected LGT.Intranet.Internal.InternalContext db { get; init; } = default!;
  #pragma warning restore IDE1006 // Naming Styles
}
