namespace LGT.Kontaktai.Models;

public class Asmuo
{
  public int ID { get; set; }
  [Display(Name = "vardas pavardė")]
  public string FullName { get; set; } = default!;
	public ICollection<Darbuotojas>? DarbovieteAssignments { get; set; }
}
