namespace LGT.Geolis.JOL;
[Table(name: "J_DOKUMENTAI", Schema = "JOL")]
public class J_DOKUMENTAI
{

  //public ICollection<J_GF_FAILAI> GF_FAILAI { get; set; } // TODO
  //public ICollection<J_DOK_FAILAI> DOK_FAILAI { get; set; } // TODO
  // public ICollection<J_LEIDINIU_UZSAKYMAI> LEIDIU_UZSAKYMAI { get; set; } // TODO
  //public ICollection<J_DOKUMENTU_APRASO_DUOMENYS> AprasoDuomenys { get; set; } // TODO
  //public ICollection<J_DOKUMENTU_VIETOS_OBJEKTAI> VietuObjektai { get; set; } // TODO
  public ICollection<Geoldba.TEL_PRI_DOK>? TelkiniaiAssignments { get; set; }

  [Column("D_ID")] public Int64 ID { get; set; }
  //[Column("D_TYPE")] public string D_TYPE { get; set; } 
  //[Column("D_DRUS_TRUMPINYS")] public string D_DRUS_TRUMPINYS { get; set; } 
  //[Column("D_DRUS_TVAR_TRUMPINYS")] public string D_DRUS_TVAR_TRUMPINYS { get; set; } 
  //[Column("D_KKALB_TRUMPINYS")] public string? D_KKALB_TRUMPINYS { get; set; } 
  //[Column("D_PIRMI_ATSAKOMYBES_DUOMENYS")] public string D_PIRMI_ATSAKOMYBES_DUOMENYS { get; set; } 
  [Column("D_PAGRINDINE_ANTRASTE")] public string Name { get; set; } = default!;
	//[Column("D_LEIDIMAS")] public int D_LEIDIMAS { get; set; } 
	[Column("D_LEIDIMO_METAI")] public int LEIDIMO_METAI { get; set; }
  //[Column("D_D_ID")] public Int64? D_D_ID { get; set; } 
  //[Column("D_D_ID_IS")] public Int64? D_D_ID_IS { get; set; } 
  //[Column("D_SALTINIO_PAVADINIMAS")] public string? D_SALTINIO_PAVADINIMAS { get; set; } 
  //[Column("D_NUMERIS_TOMAS_DALIS")] public int? D_NUMERIS_TOMAS_DALIS { get; set; } 
  //[Column("D_INFORMACIJOS_SALTINIS")] public string? D_INFORMACIJOS_SALTINIS { get; set; } 
  //[Column("D_STR_NUMERIS_TOMAS_DALIS")] public int? D_STR_NUMERIS_TOMAS_DALIS { get; set; } 
  //[Column("D_AUTORINIS_SRIFTAS")] public string? D_AUTORINIS_SRIFTAS { get; set; } 
  //[Column("D_PUSLAPIAI")] public int? D_PUSLAPIAI { get; set; } 
  //[Column("D_NAUDOJIMO_STATUSAS")] public string? D_NAUDOJIMO_STATUSAS { get; set; } 
  //[Column("D_PASTABA")] public string? D_PASTABA { get; set; } 
  //[Column("D_RYSIO_PASTABA")] public string? D_RYSIO_PASTABA { get; set; } 
  //[Column("D_IVEDIMO_DATA")] public DateTime D_IVEDIMO_DATA { get; set; } 
  //[Column("D_TIPAS")] public string D_TIPAS { get; set; } 
  //[Column("D_LEIDIMO_METAI_IKI")] public int? D_LEIDIMO_METAI_IKI { get; set; } 
  [Column("D_FONDO_NR")] public string? FONDO_NR { get; set; }
  [Column("D_APRIB_DATA")] public DateTime? APRIB_DATA { get; set; }
}
