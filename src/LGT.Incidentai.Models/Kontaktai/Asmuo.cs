namespace LGT.Incidentai.Models.Kontaktai;

public class Asmuo
{
  public override string ToString() => this.FullName;
  public int ID { get; set; }
  [Display(Name = "vardas pavardė")]
  public string FullName { get; set; } = default!;
}
