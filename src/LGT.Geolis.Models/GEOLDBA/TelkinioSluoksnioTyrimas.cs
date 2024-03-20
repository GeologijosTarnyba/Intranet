namespace LGT.Geolis.Geoldba;
[Table(name: "APIB_GEOL_SL_TYR", Schema = "GEOLDBA")]
public class TelkinioSluoksnioTyrimas
{
  [Required] public TelkinioSluoksnis? TelkinioSluoksnis { get; set; }
  [Column("AGST_AGS_SL_NR")] public int TelkinioSluoksnisID { get; set; }
  
  [Required] public TyrimuRusis? TyrimuRusis { get; set; }
  [Column("AGST_TYR_SUTR")] public string TyrimuRusisID { get; set; } = default!;

	[Column("AGST_METAI")] public int? Metai { get; set; }
  
  public JuridinisAsmuo? JuridinisAsmuo { get; set; }
  [Column("AGST_OI_KOD")] public int? JuridinisAsmuoID { get; set; }

  [Column("AGST_PASTABA")] public string? Comment { get; set; }
}
