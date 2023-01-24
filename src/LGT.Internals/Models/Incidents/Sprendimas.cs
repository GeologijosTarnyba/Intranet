using LGT.Internals.Models.Kontaktai;

namespace LGT.Internals.Models.Incidents;
public class Sprendimas : IIDed<int>
{
  public int ID { get; set; }
  public Kreipinys Kreipinys { get; set; }
  [Required] public int? KreipinysID { get; set; }
             public Darbuotojas Darbuotojas { get; set; }
  [Required] public int? DarbuotojasID { get; set; }
  [MaxLength(1000)] public string? SolutionMarkdown { get; set; }

  public DateTime? CreatedAt { get; set; }
  public DateTime? Since { get; set; }
  public DateTime? Until { get; set; }
}
