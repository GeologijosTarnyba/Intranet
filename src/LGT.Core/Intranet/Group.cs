namespace LGT.Core.Intranet;
public class Group: IIDed<int>
{
  public int ID { get; set; }
  public Column Column { get; set; } public int ColumnID { get; set; }
  public int Index { get; set; }
  [MinLength(0)]
  [MaxLength(255)]
  public string Name { get; set; }
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
  public ICollection<Link> Links { get; set; }
  public ICollection<Group_Article> ArticleAssignments { get; set; }
}
