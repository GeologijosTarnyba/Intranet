namespace LGT.Core.Intranet;
public class Group_Article : IDed
{
  public Group Group { get; set; }
  [Required(ErrorMessage = "Straipsnio priskyrimas reikalauja nurodyti grupę kuriai priskiriamas straipsnis" )]
  public int GroupID { get; set; }
  public int Index { get; set; }
  public Article Article { get; set; }
  [Required(ErrorMessage = "Straipsnio priskyrimas reikalauja nurodyti straipsnį")]
  public Guid ArticleID { get; set; }
}