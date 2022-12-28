namespace LGT.Core.Geoldba;
/// <summary>
/// Telkinių kasybos sklypų erdvinių (Oracle spatial) objektų informacijos lentelė.
/// </summary>
[Table(name: "GIS_KASYBOS_SKLYPU_EOBJ", Schema = "GEOLDBA")]
public class GIS_KASYBOS_SKLYPU_EOBJ
{
  /// <summary>
  /// Unikalus aut. gener. kodas, skirtas ry?iui su grafiniu vaizdu.
  /// </summary>
  [Key]
  [Column("KSO_GSKL_KODAS")]
  public Int64 KSO_GSKL_KODAS { get; set; } //KSO_GSKL_KODAS->NUMBER(6,0)->No->->1->Unikalus aut. gener. kodas, skirtas ry?iui su grafiniu vaizdu.
  ///// <summary>
  ///// Telkinio kasybos sklypo erdvinis objektas Oracle Spatial SDO_GEOMETRY formatu.
  ///// </summary>
  //[Column("KSO_OBJEKTAS")]public Geometry KSO_OBJEKTAS { get; set; } //KSO_OBJEKTAS->SDO_GEOMETRY->No->->2->Telkinio kasybos sklypo erdvinis objektas Oracle Spatial SDO_GEOMETRY formatu.
}
