namespace LGT.Geolis.Geoldba;
[Table(name: "GIS_GRAFIKOS_ATRIBUTU_REIKSMES", Schema = "GEOLDBA")]
public class GIS_GRAFIKOS_ATRIBUTU_REIKSMES
{
  [Key]
  [Column("GAR_ID")] public Int64 Id { get; set; }  // Grafikos objektų atributų reikšmių informacijos lentelė.
  [Required] public GIS_GRAFIKOS_ATRIBUTAI? GIS_GRAFIKOS_ATRIBUTAI { get; set; }
  [Column("GAR_GRA_ID")] public int GIS_GRAFIKOS_ATRIBUTAIId { get; set; }  // Grafikos atributo unikalus identifikatorius.

  // TODO surast kas susiję
  [Column("GAR_IPL_ID")] public int? GAR_IPL_ID { get; set; }  // Telkinio išteklių ploto unikalus identifikatorius.

  public GIS_TELKINIU_SCHEMU_EOBJ? GIS_TELKINIU_SCHEMU_EOBJ { get; set; }
  [Column("GAR_TSO_ID")] public Int64? GIS_TELKINIU_SCHEMU_EOBJId { get; set; }  // Telkinio schemos erdvinio objekto unikalus identifikatorius.

  //[Column("GAR_DATA_NUO")] public DateTime GAR_DATA_NUO { get; set; }  // Grafikos objekto atributo reikšmės galiojimo pradžia.
  [Column("GAR_CHARACTER_VALUE")] public string? GAR_CHARACTER_VALUE { get; set; }  // Grafikos objekto atributo reikšmė CHARACTER formatu.
  [Column("GAR_NUMBER_VALUE")] public int? GAR_NUMBER_VALUE { get; set; }  // Grafikos objekto atributo reikšmė FLOAT formatu.
  [Column("GAR_DATE_VALUE")] public DateTime? GAR_DATE_VALUE { get; set; }  // Grafikos objekto atributo reikšmė DATE formatu.
  public override string ToString() => GAR_CHARACTER_VALUE ?? GAR_NUMBER_VALUE?.ToString() ?? GAR_DATE_VALUE.ToString() ?? "<null>";
  //[Column("GAR_DATA_IKI")] public DateTime? GAR_DATA_IKI { get; set; }  // Grafikos objekto atributo reikšmės galiojimo pabaiga.
}