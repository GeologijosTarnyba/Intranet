namespace LGT.Intranet.Models;
/// <summary>
///  Nuorodų grupė puslapio stulpelyje
/// </summary>
public class Group
{
  public int Id { get; set; }
  [Required] public Column? Column { get; set; }
  public int ColumnId { get; set; }
  public int Index { get; set; }
  [MinLength(0)]
  [MaxLength(255)]
  public string Name { get; set; } = default!;
	public bool IsPublic { get; set; }
  public string? Markdown { get; set; }
  #region Constructors
  public Group() : base() { }
  public Group(Column column, string name) : this()
  {
    this.Column = column;
    this.Name = name;
  }
  #endregion
  public ICollection<Link>? Links { get; set; }
  public ICollection<Group_Article>? ArticleAssignments { get; set; }
}
