using LGT.Internals.Models.Kontaktai;
namespace LGT.Internals.Models.Incidents;
public class AptarnaujantiImone : Darboviete
{
  public bool IsActive { get; set; }
  public ICollection<Kreipinys> Krepiniai { get; set; }
  public ICollection<AptarnavimoSutartis> Sutartys { get; set; }
}
