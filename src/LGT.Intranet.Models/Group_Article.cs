namespace LGT.Intranet.Models;
public class Group_Article
{
  public Guid Id { get; set; }
  [Required] public Group? Group { get; set; }
  [Required(ErrorMessage = "Straipsnio priskyrimas reikalauja nurodyti grupę kuriai priskiriamas straipsnis" )]
  public int GroupId { get; set; }
  public int Index { get; set; }
  [Required] public Article? Article { get; set; }
  [Required(ErrorMessage = "Straipsnio priskyrimas reikalauja nurodyti straipsnį")]
  public Guid ArticleId { get; set; }
}
