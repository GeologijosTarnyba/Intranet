using LGT.Internals.Models.Kontaktai;

namespace LGT.Internals.Models.Incidents;
public class InformacinisIsteklius : IIDed<string>
{
  public string ID { get; set; }
  [MaxLength(255)]
  public string Name { get; set; }

  public InformacinisIsteklius? Parent { get; set; } public ICollection<InformacinisIsteklius> Children { get; set; }
  [Column("Parent")]
  public string? ParentID { get; set; }

  public Darboviete Darboviete { get; set; }
  [Column("Priklauso")]
  [Required]
  public string? DarbovieteID { get; set; }

}
