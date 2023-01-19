﻿namespace LGT.Internals.Models.Incidents;
public class Incidentas : IIDed<int>
{
  public int ID { get; set; }
  [Required]
  public DateTime? CreatedAt { get; set; }
  [Display(Name = "Tarnybos informacinio ištekliaus pavadinimas")]
  public InformacinisIsteklius InformacinisIsteklius { get; set; }
  public string InformacinisIstekliusID { get; set; }
  [Display(Name = "Požymio kodas")]
  public IncidentoPozymis? Pozymis { get; set; }
  public int? PozymisID { get; set; }
  [Display(Name = "Įvykio aprašymas")][MaxLength(1000)]
  [Required]
  public string? Desc { get; set; }
  [Display(Name = "Pradžia")]
  [Required] public DateTime? Since { get; set; }
  [Display(Name = "Pabaiga")]
  public DateTime? Until { get; set; }
  [MaxLength(1000)]
  [Display(Name = "Sutrikimo priežastis")]
  public string? Reason { get; set; }

  public bool? IsPublic { get; set; }

  [Display(Name = "Krepiniai")]
  public ICollection<Kreipinys> Kreipiniai { get; set; }
  [Display(Name = "Pranešimai")]
  public ICollection<Skundas> Skundai { get; set; }
}
