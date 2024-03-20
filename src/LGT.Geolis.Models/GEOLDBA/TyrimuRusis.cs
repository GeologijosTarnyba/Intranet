namespace LGT.Geolis.Geoldba;
[Table(name: "TYRIMU_RUSYS", Schema = "GEOLDBA")]
public class TyrimuRusis
{
  [Key]
  [Column("TYR_SUTR")] public string ID { get; set; } = default!; // Tyrimo trumpinys, naudojamas GEOLIS duomenims tvarkyti
	[Column("TYR_PAV")] public string NameU { get; set; } = default!;  // Tyrimo pavadinimas
	public TyrimuRusis? Parent { get; set; } 
  [Column("TYR_TYR_SUTR")] public string? ParentID { get; set; }  // Hierarchinis tyrimo priklausomumas
  public ICollection<TyrimuRusis>? Children { get; set; }

  [Column("TYR_KODAS")] public string? Kodas { get; set; }  // Tyrimo kodas, naudojamas Žemės gelmių registro duomenų tvarkymui. ŽGR naudojami tik 1-5 ženklai. Teikiant ŽGR duomenis, vietoj 7 ženklų imti tik pirmus 5.
  [Column("TYR_PPAV")] public string NameFull { get; set; } = default!;  // Pilnas tyrimo pavadinimas, atsižvelgiant į hierarchinį priklausomumą
  //[Column("TYR_GT_TRUMP")] public string? TYR_GT_TRUMP { get; set; }  // Geologinio tyrimo etapo trumpinys (naud.iškasenų sluoksnio istirtumas)
  //[Column("TYR_REGISTR_FORM")] public string? TYR_REGISTR_FORM { get; set; }  // Tyrimo registravimo lapo, pildomo registruojant šią tyrimų rūšį, tipas
  //[Column("TYR_EPAS_ID")] public Int64? TYR_EPAS_ID { get; set; }  // EPAS sistemos įrašo identifikatorius
  /// <summary>
  /// Galioja iki
  /// </summary>
  [Column("TYR_GALIOJA_IKI")] public DateTime? Until { get; set; }
}
