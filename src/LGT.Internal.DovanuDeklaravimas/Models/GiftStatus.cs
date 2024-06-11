using System.ComponentModel.DataAnnotations;

namespace LGT.Internal.DovanuDeklaravimas.Models;
public class GiftStatus
{
    public DateTime CreatedAt { get; set; }
    public Guid Id { get; set; }

    [Required]
    public Gift Dovana { get; set; } = default!;
    public int DovanaId { get; set; }

    [Required]
    public string Status { get; set; } = null!;
}
