namespace LGT.Incidentai.Models;
public class InformacinisIsteklius
{
  public override string ToString() => this.Name!;
  [Required]
  [MaxLength(255)]
  [Key]
  public string? ID { get; set; }
  [Required]
  [MaxLength(255)]
  public string? Name { get; set; }

  public InformacinisIsteklius? Parent { get; set; } 
  public ICollection<InformacinisIsteklius>? Children { get; set; }
  [Column("Parent")]
  [MaxLength(255)]
  public string? ParentID { get; set; }

  [Required]
  public Kontaktai.Darboviete? Darboviete { get; set; }
  [Column("Priklauso")]
  [MaxLength(32)]
  public string DarbovieteID { get; set; } = default!;
}
