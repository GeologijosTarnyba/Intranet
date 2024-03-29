namespace LGT.Incidentai.Models;
public class Sprendimas
{
  public int ID { get; set; }
  [Required] public Kreipinys? Kreipinys { get; set; }
  public int? KreipinysID { get; set; }
  [Required] public Kontaktai.Darbuotojas? Darbuotojas { get; set; }
  public int? DarbuotojasID { get; set; }
  [MaxLength(1000)] public string? SolutionMarkdown { get; set; }

  public DateTime? CreatedAt { get; set; }
  public DateTime? Since { get; set; }
  public DateTime? Until { get; set; }
}
