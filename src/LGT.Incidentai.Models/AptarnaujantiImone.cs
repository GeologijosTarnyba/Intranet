using LGT.Kontaktai.Models;

namespace LGT.Incidentai.Models;
public class AptarnaujantiImone : Darboviete
{
  public bool IsActive { get; set; }
  public ICollection<Kreipinys>? Krepiniai { get; set; }
  public ICollection<AptarnavimoSutartis>? Sutartys { get; set; }
}
