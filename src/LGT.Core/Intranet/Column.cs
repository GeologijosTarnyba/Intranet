namespace LGT.Core.Intranet;
public class ColumnSizes : Owned
{
  [Range(1, 12, ErrorMessage = "Stulpelių pločiai nurodomi skaičiumi tarp 1 ir 12, arba paliekami nenurodyti")]
  public int? Default { get; set; }
  [Range(1, 12, ErrorMessage = "Stulpelių pločiai nurodomi skaičiumi tarp 1 ir 12, arba paliekami nenurodyti")]
  public int? LG { get; set; }
  [Range(1, 12, ErrorMessage = "Stulpelių pločiai nurodomi skaičiumi tarp 1 ir 12, arba paliekami nenurodyti")]
  public int? MD { get; set; }
  [Range(1, 12, ErrorMessage = "Stulpelių pločiai nurodomi skaičiumi tarp 1 ir 12, arba paliekami nenurodyti")]
  public int? SM { get; set; }
  [Range(1, 12, ErrorMessage = "Stulpelių pločiai nurodomi skaičiumi tarp 1 ir 12, arba paliekami nenurodyti")]
  public int? XS { get; set; }


  public override string ToString()
  {
    var list = new List<string>();
    if (Default != null)
      list.Add($"col-{this.Default}");
    if (LG != null)
      list.Add($"col-lg-{this.LG}");
    if (MD != null)
      list.Add($"col-md-{this.MD}");
    if (SM != null)
      list.Add($"col-sm-{this.SM}");
    if (XS != null)
      list.Add($"col-xs-{this.XS}");
    if (list.Any())
    {
      return string.Join(" ", list);
    }

    return "col";
  }
}
public class Column : IIDed<int>
{

  public int ID { get; set; }
  public Page Page { get; set; }
  public int PageID { get; set; }
  public int Index { get; set; }
  public ColumnSizes Sizes { get; set; } = new();

  #region Constructors
  public Column() : base() { }
  public Column(Page page) : this()
  {
    this.Page = page;
  }
  #endregion
  public ICollection<Group> Groups { get; set; }
}