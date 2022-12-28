namespace LGT.Core.Geoldba;
[Table(name: "ASMENYS", Schema = "GEOLDBA")]
public class Asmuo
{
  public ICollection<JungtinesVeiklosSutartis> JungtinesVeiklosSutartys_UzKuriasAtsakingas { get; set; }
  public ICollection<Geoldba.Leidimas> Leidimai { get; set; }
  public ICollection<Inv.InventoriausVieta> InventoriausVietos { get; set; }
  [Key]
  [Column(name: "ASM_ID")]
  public int ID { get; set; } // NUMBER(7,0) No
  [Column(name: "ASM_PAVARDE")]
  public string Pavarde { get; set; } // VARCHAR2(25 BYTE) No
  [Column(name: "ASM_VARDAS")]
  public string Vardas { get; set; } // VARCHAR2(20 BYTE) No
  [Column(name: "ASM_PASO_DATA")] public DateTime? ASM_PASO_DATA { get; set; } // DATE Yes
  [Column(name: "ASM_DIRBA_IKI")] public DateTime? DateIki { get; set; } // DATE Yes
  [Column(name: "ASM_ORGIM_KOD")] public int? JuridinisAsmuoID { get; set; } // NUMBER(5,0) Yes
  public JuridinisAsmuo? JuridinisAsmuo { get; set; }
  //[Column(name: "ASM_ATV_ID")] public string? ASM_ATV_ID { get; set; } //   VARCHAR2(20 BYTE) Yes
  #region NotMapped
  //[Column(name: "ASM_KOD")]public int? ASM_KOD { get; set; } // NUMBER(11,0)  Yes
  //[Column(name: "ASM_DARBO_TELEFONAS")]public string? ASM_DARBO_TELEFONAS { get; set; } //  VARCHAR2(10 BYTE) Yes
  //[Column(name: "ASM_PASO_NUM")]public string? ASM_PASO_NUM { get; set; } //   VARCHAR2(8 BYTE)  Yes
  //[Column(name: "ASM_SDP_NUM")]public string? ASM_SDP_NUM { get; set; } //  VARCHAR2(9 BYTE)  Yes
  //[Column(name: "ASM_PROFESIJA")]public string? ASM_PROFESIJA { get; set; } //  VARCHAR2(50 BYTE) Yes
  //[Column(name: "ASM_PAREIGOS")]public string? ASM_PAREIGOS { get; set; } //   VARCHAR2(50 BYTE) Yes
  //[Column(name: "ASM_STAZAS")]public DateOnly? ASM_STAZAS { get; set; } // DATE Yes
  //[Column(name: "ASM_DIRBA_NUO")]public DateOnly? ASM_DIRBA_NUO { get; set; } // DATE  Yes
  //[Column(name: "ASM_ADR")]public string? ASM_ADR { get; set; } //  VARCHAR2(100 BYTE)  Yes
  //[Column(name: "ASM_VARTOTOJAS")]public string? ASM_VARTOTOJAS { get; set; } //   VARCHAR2(30 BYTE) Yes
  //[Column(name: "ASM_DATA")]public DateOnly? ASM_DATA { get; set; } // DATE Yes
  //[Column(name: "ASM_EPAS_ID")]public int? ASM_EPAS_ID { get; set; } // NUMBER(38,0)  Yes
  //[Column(name: "ASM_PVARDAS")]public string? ASM_PVARDAS { get; set; } //  VARCHAR2(50 BYTE) Yes
  //[Column(name: "ASM_PPAVARDE")]public string? ASM_PPAVARDE { get; set; } //   VARCHAR2(50 BYTE) Yes
  #endregion
  public override string ToString()
  {
    return $"{this.Vardas} {this.Pavarde}[{this.ID}]";
  }
}
