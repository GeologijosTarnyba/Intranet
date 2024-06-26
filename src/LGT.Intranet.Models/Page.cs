﻿namespace LGT.Intranet.Models;
/// <summary>
/// Intraneto puslapis
/// </summary>
public class Page
{
  public int Id { get; set; }

  [MaxLength(16)]
  public string? Key { get; set; }
  [MaxLength(255)]
  public string? Name { get; set; }
  public bool IsPublic { get; set; }
  [Comment("Svarbus puslapiai bus matomi intraneto apacios viduryje")]
  public bool IsImportant { get; set; } = false;
  [MaxLength(32)]
  [Comment("Trumpas pavadinimas naudojamas svarbiu puslapiu skiltyje")]
  public string? Nam { get; set; }
  #region Constructors
  public Page() : base() { }
  public Page(int id, string nam, string name) : this()
  {
    this.Id = id;
    this.Nam = nam;
    this.Name = name;
  }
  #endregion
  public ICollection<Column>? Columns { get; set; }
}
