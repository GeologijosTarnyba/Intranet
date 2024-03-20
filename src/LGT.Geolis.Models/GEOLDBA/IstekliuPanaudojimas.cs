namespace LGT.Geolis.Geoldba;
[Table(name: "IST_PANAUDOJIMAS", Schema = "GEOLDBA")]
public class IstekliuPanaudojimas
{
  // HasKey(item => new { item.TelkinysID, item.TelkinioSluoksnisID, item.PanaudojimoSritisID })
  [Column("IPN_TELK_KODAS")]
  public int TelkinysID { get; set; } //IPN_TELK_KODAS->NUMBER(5,0)->No->->1->
  [Required] public Telkinys? Telkinys { get; set; }

  [Column("IPN_AGS_SL_NR")]
  public int TelkinioSluoksnisID { get; set; } //IPN_AGS_SL_NR->NUMBER(6,0)->No->->2->
  [Required] public TelkinioSluoksnis? TelkinioSluoksnis { get; set; }

  [Column("IPN_PNS_KODAS")]
  public string PanaudojimoSritisID { get; set; } = default!; //IPN_PNS_KODAS->VARCHAR2(10 BYTE)->No->->3->
	[Required] public PanaudojimoSritis? PanaudojimoSritis { get; set; }
}
