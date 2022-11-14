namespace LGT.Core.Intranet;
public class Message : IIDed<int>
{
  public int ID { get; set; }
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
  public string Header { get; set; }
  public Article? Article { get; set; } public Guid? ArticleID { get; set; }

  
}
