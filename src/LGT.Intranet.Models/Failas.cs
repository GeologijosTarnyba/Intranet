namespace LGT.Intranet.Models;
public class Failas
{
  public Guid Id { get; set; }
  public string? InternalName { get; set;}
  public string? Name { get; set; }
  [Required] public string? RootPath { get; set; }
}
