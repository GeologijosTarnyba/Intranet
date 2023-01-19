using LGT.Internals.Models.Incidents;

namespace LGT.Internals.Models.Kontaktai;
public class Asmuo : IIDed<int>
{
  public int ID { get; set; }
  [Display(Name = "vardas pavardė")]
  public string FullName { get; set; }
  public ICollection<Darbuotojas> DarbovieteAssignments { get; set; }
  public ICollection<Skundas> Skundai { get; set; }
}
