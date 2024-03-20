namespace LGT.Geolis.GEOLDBA.TYRIMAI;
[Table(name: "ZGRT_VIETOS", Schema = "TYRIMAI")]
public class ZGRT_VIETOS
{
  [Key]
  [Column("ZGTV_ID")] public Int64 ZGTV_ID { get; set; }  // Identifikatorius (pirminis raktas)
  [Column("ZGTV_NR")] public int ZGTV_NR { get; set; }  // Vietos numeris (generuojamas automatiškai, kiekvienam tyrimui pradedant nuo 1, 2, ..).
  [Column("ZGTV_GRAFINIS_PRIMITYVAS")] public string ZGTV_GRAFINIS_PRIMITYVAS { get; set; } = default!;  // Erdvinio objekto grafinis tipas: taškas, linija, plotas.
  //[Column("ZGTV_ZGT_ID")] public int ZGTV_ZGT_ID { get; set; }  // Tyrimo identifikacinis kodas.
  //[Column("ZGTV_ATV_ID")] public string ZGTV_ATV_ID { get; set; }  // Adresas.
  //[Column("ZGTV_ADRESAS")] public string? ZGTV_ADRESAS { get; set; }  // Laisvu tekstu nurodomi papildomi duomenys: namo, sklypo nr. ir pan.
  //[Column("ZGTV_PAVADINIMAS")] public string? ZGTV_PAVADINIMAS { get; set; }  // Vietos pavadinimas.
  //[Column("ZGTV_PAP_ID")] public string? ZGTV_PAP_ID { get; set; }  // Papildomas adresas.
  //[Column("ZGTV_GOT_SUTRUMPINIMAS")] public string? ZGTV_GOT_SUTRUMPINIMAS { get; set; }  // Geologinio objekto tipo sutrumpinimas, pirminis raktas
  //[Column("ZGTV_GOBJ_KOD")] public int? ZGTV_GOBJ_KOD { get; set; }  // Geologinio objekto kodas, pirminis raktas
  //[Column("ZGTV_GR_NR")] public int? ZGTV_GR_NR { get; set; }  // Gręžiniui suteiktas unikalus numeris, pirminis raktas
  //[Column("ZGTV_TELK_KODAS")] public int? ZGTV_TELK_KODAS { get; set; }  // Unikalus, aut. gen. kodas, skirtas ryšiui su grafika.
  //[Column("ZGTV_EPAS_ID")] public Int64? ZGTV_EPAS_ID { get; set; }  // EPAS sistemos irašo identifikatorius.
  //[Column("ZGTV_AU_VARTOTOJAS")] public string? ZGTV_AU_VARTOTOJAS { get; set; } 
}