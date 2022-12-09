namespace LGT.Core.Geoldba.Views;
[Keyless]
[Table(name: "W_GSKL_LEID", Schema = "GEOLDBA")]
public class W_GSKL_LEID
{
  [Column("GSKL_KODAS")] public int GSKL_KODAS { get; set; } 
  [Column("GSKL_TELK_KODAS")] public int GSKL_TELK_KODAS { get; set; } 
  [Column("GSKL_NUMERIS")] public string GSKL_NUMERIS { get; set; } 
  //[Column("GSKL_PLOTAS")] public decimal GSKL_PLOTAS { get; set; } 
  //[Column("GSKL_IST_KIEKIS")] public decimal? GSKL_IST_KIEKIS { get; set; } 
  //[Column("GSKL_IST_KIEKIS_T")] public decimal? GSKL_IST_KIEKIS_T { get; set; } 
  //[Column("GSKL_IST_DATA")] public DateTime? GSKL_IST_DATA { get; set; } 
  //[Column("GSKL_MAVNT")] public string? GSKL_MAVNT { get; set; } 
  //[Column("GSKL_PROJ_DATA")] public string? GSKL_PROJ_DATA { get; set; } 
  [Column("LEID_ID")] public int LEID_ID { get; set; } 
  [Column("LEID_NR")] public string LEID_NR { get; set; } 
  //[Column("LEID_ISDAVIMO_DATA")] public DateTime LEID_ISDAVIMO_DATA { get; set; } 
  //[Column("LEID_DATA_NUO")] public DateTime LEID_DATA_NUO { get; set; } 
  //[Column("LEID_DATA_IKI")] public DateTime? LEID_DATA_IKI { get; set; } 
  //[Column("LEID_ORGIM_KOD")] public int? LEID_ORGIM_KOD { get; set; } 
  [Column("LEID_JVS_ID")] public int? LEID_JVS_ID { get; set; } 
  [Column("LEID_ASM_ID")] public int? LEID_ASM_ID { get; set; } 
}
