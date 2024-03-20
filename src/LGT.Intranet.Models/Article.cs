namespace LGT.Intranet.Models;
public class Article
{
	public Guid Id { get; set; }
  public Accessibility Accessibility { get; set; } = Accessibility.Private;
  [MaxLength(255)]
  [Required(ErrorMessage = "Straipsnis turi būti užvadintas, kad jį būtų galima atskirti.")]
  public string InternalName { get; set; } = default!;
	[MaxLength(255)]
  public string? Name { get; set; }
  
  public string? BodyMarkdown { get; set; }

  public ICollection<Group_Article>? GroupAssignments { get; set; }
}
