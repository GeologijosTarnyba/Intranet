namespace LGT.Geolis.GEOLDBA.TYRIMAI;
[Table(name: "ZEMES_GELMIU_TYRIMAI", Schema = "TYRIMAI")]
public class ZEMES_GELMIU_TYRIMAI
{
  [Key]
  [Column("ZGT_ID")] public int ZGT_ID { get; set; }  // Tyrimo identifikacinis kodas
  //[Column("ZGT_REG_DATA")] public DateTime ZGT_REG_DATA { get; set; }  // Tyrimo registracijos data
  //[Column("ZGT_PR_DATA")] public DateTime ZGT_PR_DATA { get; set; }  // Tyrimo darbų pradžios data
  //[Column("ZGT_PB_DATA")] public DateTime ZGT_PB_DATA { get; set; }  // Tyrimo darbų pabaigos data
  //[Column("ZGT_TIKSLAS")] public string ZGT_TIKSLAS { get; set; }  // Tyrimo tikslas
  //[Column("ZGT_FINANSAVIMAS")] public string ZGT_FINANSAVIMAS { get; set; }  // Finansavimo pobūdis
  //[Column("ZGT_ITD_KODAS")] public int? ZGT_ITD_KODAS { get; set; }  // Išteklių tvirtinimo dokumento kodas
  //[Column("ZGT_OI_PATEIKE")] public int? ZGT_OI_PATEIKE { get; set; }  // Organizacijos, pateikusios duomenis registracijai, kodas
  //[Column("ZGT_OI_ATLIKO")] public int? ZGT_OI_ATLIKO { get; set; }  // Organizacijos, atlikusios tyrimus, kodas
  //[Column("ZGT_LEID_ID")] public int? ZGT_LEID_ID { get; set; }  // Leidimo, išduoto tyrimus atliekančiai organizacijai, kodas
  //[Column("ZGT_ISREG_DATA")] public DateTime? ZGT_ISREG_DATA { get; set; }  // Tyrimo išregistravimo data
  //[Column("ZGT_ISREG_PRIEZASTIS")] public string? ZGT_ISREG_PRIEZASTIS { get; set; }  // Tyrimo išregistravimo priežastis
  //[Column("ZGT_UZSAKE_OI_KOD")] public int? ZGT_UZSAKE_OI_KOD { get; set; }  // Organizacijos, užsakiusios tyrimų darbus, kodas
  //[Column("ZGT_UZSAKE_ASM_ID")] public int? ZGT_UZSAKE_ASM_ID { get; set; }  // Fizinio asmens, užsakiusio tyrimo darbus, kodas
  //[Column("ZGT_UZREG_ASM_ID")] public int ZGT_UZREG_ASM_ID { get; set; }  // LGT darbuotojo, užregistravusio tyrimą, kodas
  //[Column("ZGT_PASTABA")] public string? ZGT_PASTABA { get; set; } 
  //[Column("ZGT_NUMERIS")] public string ZGT_NUMERIS { get; set; }  // Tyrimo numeris
  //[Column("ZGT_NLEID_ID")] public int? ZGT_NLEID_ID { get; set; }  // Leidimo, išduoto tyrimus užsakiusiai organizacijai, kodas
  //[Column("ZGT_BUV_ID")] public int? ZGT_BUV_ID { get; set; }  // Perregistruoto tyrimo pradinio tyrimo kodas
  //[Column("ZGT_UZSAKE_JVS_ID")] public int? ZGT_UZSAKE_JVS_ID { get; set; } 
  //[Column("ZGT_ASM_ID_PATEIKE")] public int? ZGT_ASM_ID_PATEIKE { get; set; }  // Išorinis raktas į ASMENYS (pateikė)
  //[Column("ZGT_JVS_ID_ATLIKO")] public int? ZGT_JVS_ID_ATLIKO { get; set; }  // Išorinis raktas į JUNGTINES_VEIKLOS_SUTARTYS (atliko)
  //[Column("ZGT_ASM_ID_ATLIKO")] public int? ZGT_ASM_ID_ATLIKO { get; set; }  // Išorinis raktas į ASMENYS (atliko)
  //[Column("ZGT_EPAS_ID")] public Int64? ZGT_EPAS_ID { get; set; }  // EPAS sistemos įrašo identifikatorius
  //[Column("ZGT_AU_VARTOTOJAS")] public string? ZGT_AU_VARTOTOJAS { get; set; } 
  //[Column("ZGT_TIPAS_GOB_SUTR")] public string? ZGT_TIPAS_GOB_SUTR { get; set; } 
}