namespace LGT.Core.Intranet;
public class Article : IDed, IIDed<Guid>
{
  public Accessibility Accessibility { get; set; } = Accessibility.Private;
  [MaxLength(255)]
  [Required(ErrorMessage = "Straipsnis turi būti užvadintas, kad jį būtų galima atskirti.")]
  public string InternalName { get; set; }
  [MaxLength(255)]
  public string? Name { get; set; }
  
  public string? BodyMarkdown { get; set; }

  public ICollection<Group_Article> GroupAssignments { get; set; }
}
