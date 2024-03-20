namespace LGT.Intranet.Models;
public class Message
{
  public int Id { get; set; }
  public bool IsPublic { get; set; }
  public int Index { get; set; } = 100;
  [Required(ErrorMessage = "Privaloma nurodyti data nuo kada bus rodomas pranešimas")]
  public DateTime ShowSince { get; set; }
  [Required(ErrorMessage = "Privaloma nurodyti datą nuo")]
  public DateTime Since { get; set; }
  [Required(ErrorMessage = "Privaloma nurodyti datą iki")]
  public DateTime Until { get; set; }
  [Required(ErrorMessage = "Nurodyti antraštės lauką yra privaloma")]
  [MinLength(1)]
  [MaxLength(255)]
  public string Header { get; set; } = default!;
  public Article? Article { get; set; } public Guid? ArticleId { get; set; }
}
