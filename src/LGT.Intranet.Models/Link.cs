namespace LGT.Intranet.Models;
/// <summary>
/// Nuoroda intraneto puslapio stulpelio grupėje
/// </summary>
public class Link
{
  public int Id { get; set; }
  [Required] public Group? Group { get; set; }
  public int GroupId { get; set; }
  public int Index { get; set; }
  [MaxLength(255)]
  public string Name { get; set; } = default!;
  [MaxLength(255)]
  public string? Comment { get; set; }
  [MaxLength(1024)]
  [Required(ErrorMessage = "Nuorodos laukas privalomas")]
  public string Url { get; set; } = default!;
  public bool IsPublic { get; set; }
  [Comment("Prie uzrakintu nuorodu bus rodoma spynele.")]
  public bool IsLocked { get; set; } = false;
  /// <summary>
  /// Blank target reiškia kad nuoroda atsidarys naujame tabe.
  /// </summary>
  public bool IsTargetBlank { get; set; }
  public DateTime? NewUntil { get; set; }
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
