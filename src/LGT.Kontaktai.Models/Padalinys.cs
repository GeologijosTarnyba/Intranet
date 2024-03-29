namespace LGT.Kontaktai.Models;
public class Padalinys
{
  public override string? ToString() => this.Name;
  public Guid Id { get; set; }
  [Required] public Darboviete? Darboviete { get; set; }
  public string? DarbovieteId { get; set; }
  [Required]
  [MaxLength(512)]
  public string? Name { get; set; }
  [MaxLength(16)]
  public string? NameShort { get; set; }
  public int? Weight { get; set; }
  public List<Etatas> Etatai { get; set; } = [];
}
