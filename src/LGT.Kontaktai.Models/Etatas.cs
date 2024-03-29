namespace LGT.Kontaktai.Models;
public class Etatas
{
  public override string? ToString() => this.Name?.Vardininkas;
  public Guid Id { get; set; }
  [Required] public EtatasName? Name { get; set; }
  [Required] public Darboviete? Darboviete { get; set; }

  /// <summary>
  /// Nuo kada sukurtas etatas
  /// </summary>
  public DateTime? Since { get; set; }
  /// <summary>
  /// Kada panaikintas etatas
  /// </summary>
  public DateTime? Until { get; set; }

  public Padalinys? Padalinys { get; set; }
  public List<Darbuotojas> Darbuotojai { get; set; } = [];
}
