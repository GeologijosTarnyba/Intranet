using System.ComponentModel.DataAnnotations;

namespace LGT.Internal.DovanuDeklaravimas.Models;
public class Gift
{
  public int Id { get; set; }

  public GiftTypes? Type { get; set; }
  public DateTime? GiftedAt { get; set; }
  public string? Gifter { get; set; }
  public string? Reason { get; set; }
  public string? Location { get; set; }
  [Required]
  public string Reciever { get; set; } = null!;
  [Required]
  public int? Amount { get; set; }

  [Required]
  public string Name { get; set; } = null!;
  public string? Description { get; set; }

  public decimal? Price { get; set; }
  [Required]
  public VertesNustatymoBudai? PriceApproximationMethod { get; set; }
  
  public List<GiftStatus> Statuses { get; set; } = [];

  public string? Comment { get; set; }
}
