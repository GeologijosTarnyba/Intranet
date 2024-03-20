namespace LGT.Kontaktai.Models;
public class Darbuotojas
{
  public int ID { get; set; }
  public DateTime? CreatedAt { get; set; }
  [Required] public Darboviete? Darboviete { get; set; }
  [Column("Darboviete")]
  public string DarbovieteID { get; set; } = default!;
  public Asmuo? Asmuo { get; set; }
  [Column("Asmuo")]
  public int? AsmuoID { get; set; }

  public DateTime? Since { get; set; }
  public DateTime? Until { get; set; }

  [Column("Pareigybe")]
  [MaxLength(255)]
  public string? Name { get; set; }
  [EmailAddress()]
  public string? Email { get; set; }
  [MaxLength(255)] public string? Tel1 { get; set; }
  [MaxLength(255)] public string? Tel2 { get; set; }
  [MaxLength(255)] public string? Tel3 { get; set; }
  [MaxLength(255)] public string? Tel4 { get; set; }

  //public ICollection<Skundas> Skundai { get; set; }
  //public ICollection<Sprendimas> Sprendimai { get; internal set; }
}
