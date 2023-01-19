using LGT.Internals.Models.Incidents;

namespace LGT.Internals.Models.Kontaktai;
public class Darboviete : IIDed<string>
{
  [MaxLength(32)]
  public string ID { get; set; }
  [MaxLength(255)]
  [Required]
  public string? Name { get; set; }

  public ICollection<Darbuotojas> DarbuotojasAssignments { get; set; }
  public ICollection<InformacinisIsteklius> InformaciniaiIstekliai { get; set; }
  public ICollection<Kreipinys> Kreipiniai { get; set; }
}
