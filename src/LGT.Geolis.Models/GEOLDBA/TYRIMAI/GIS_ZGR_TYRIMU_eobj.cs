namespace LGT.Geolis.GEOLDBA.TYRIMAI;
[Table(name: "GIS_ZGR_TYRIMU_eobj", Schema = "TYRIMAI")]
public class GIS_ZGR_TYRIMU_eobj
{
  [Key]
  [Column("ZGTO_ID")] public int ZGTO_ID { get; set; }  // Žemės gelmių tyrimo objekto unikalus identifikatorius
  [Required] public ZEMES_GELMIU_TYRIMAI? ZEMES_GELMIU_TYRIMAI { get; set; }
  [Column("ZGTO_ZGT_ID")] public int ZEMES_GELMIU_TYRIMAIID { get; set; }  // Tyrimo identifikacinis kodas
  [Column("ZGTO_OBJ_NR")] public int ZGTO_OBJ_NR { get; set; }  // ŽGR tyrimo erdvinio objekto eilės numeris.
  //[Column("ZGTO_OBJEKTAS")] public Geometry ZGTO_OBJEKTAS { get; set; }  // Tyrimo ploto erdvinis objektas Oracle Spatial SDO_GEOMETRY formatu.
  public ZGRT_VIETOS? ZGRT_VIETOS { get; set; }
  [Column("ZGTO_ZGTV_ID")] public Int64? ZGRT_VIETOSID { get; set; }  // Išorinis raktas į ZGRT_VIETOS
  //[Column("ZGTO_EPAS_ID")] public Int64? ZGTO_EPAS_ID { get; set; }  // EPAS sistemos įrašo identifikatorius
}
