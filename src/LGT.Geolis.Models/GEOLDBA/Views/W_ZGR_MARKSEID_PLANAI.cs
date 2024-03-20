using Microsoft.EntityFrameworkCore;

namespace LGT.Geolis.Geoldba.Views;
[Keyless]
[Table(name: "W_ZGR_MARKSEID_PLANAI", Schema = "GEOLDBA")]
public class W_ZGR_MARKSEID_PLANAI
{
  [Column("GSKL_TELK_KODAS")] public int? TelkinysID { get; set; } 
  [Column("TELK_PAV")] public string? Telkinys_Name { get; set; } 
  [Column("TELK_IST_TRUMP")] public string? IRID { get; set; } 
  [Column("GSKL_KODAS")] public int? GavybosSklypasID { get; set; } 
  [Column("GSKL_NUMERIS")] public string? GavybosSklypas_NR { get; set; } 
  [Column("LEID_NR")] public string? LeidimasID { get; set; } 
  [Column("LEID_DATA_NUO")] public DateTime? LEID_DATA_NUO { get; set; } 
  [Column("LEID_DATA_IKI")] public DateTime? LEID_DATA_IKI { get; set; } 
  [Column("IMONE")] public string? Kam { get; set; } 
  [Column("MARKS_DATA")] public DateTime? MARKS_DATA { get; set; } 
}