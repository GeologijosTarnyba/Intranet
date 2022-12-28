namespace LGT.Core.Intranet;
public class Link : IIDed<int>
{
  public int ID { get; set; }
  public Group Group { get; set; }
  public int GroupID { get; set; }
  public int Index { get; set; }
  [MaxLength(255)]
  public string Name { get; set; }
  [MaxLength(255)]
  public string? Comment { get; set; }
  [MaxLength(1024)]
  [Required(ErrorMessage = "Nuorodos laukas privalomas")]
  public string Url { get; set; }
  public bool IsPublic { get; set; }
  [Comment("Prie uzrakintu nuorodu bus rodoma spynele.")]
  public bool IsLocked { get; set; } = false;
  public bool IsTargetBlank { get; set; }
  #region Constructors
  public Link() : base() { }
  public Link(Group group, string name, string url) : this()
  {
    this.Group = group;
    this.Name = name;
    this.Url = url;
  }
  #endregion
}
