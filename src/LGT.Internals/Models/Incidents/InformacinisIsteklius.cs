using LGT.Internals.Models.Kontaktai;

namespace LGT.Internals.Models.Incidents;
public class InformacinisIsteklius
{
  [Required]
  [MaxLength(255)]
  [Key]
  public string? ID { get; set; }
  [Required]
  [MaxLength(255)]
  public string? Name { get; set; }

  public InformacinisIsteklius? Parent { get; set; } public ICollection<InformacinisIsteklius> Children { get; set; }
  [Column("Parent")]
  [MaxLength(255)]
  public string? ParentID { get; set; }

  public Darboviete Darboviete { get; set; }
  [Column("Priklauso")]
  [Required]
  [MaxLength(32)]
  public string? DarbovieteID { get; set; }

}
