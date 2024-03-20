namespace LGT.Geolis.Geoldba;
[Table(name: "TELK_IST_PANAUDOJIMAS", Schema = "GEOLDBA")]
public class TelkinioIstekliuPanaudojimas
{
  //mb.Entity<Geoldba.TelkinioIstekliuPanaudojimas>().HasKey(item => new { item.TelkinysID, item.PanaudojimoSritisID });
  [Column("IPN_TELK_KODAS")]
  public int TelkinysID { get; set; } //IPN_TELK_KODAS->NUMBER(5,0)->No->->1->
  [Required] public Telkinys? Telkinys { get; set; }
  [Column("IPN_PNS_KODAS")]
  public string PanaudojimoSritisID { get; set; } = default!; //IPN_PNS_KODAS->VARCHAR2(10 BYTE)->No->->2->
	[Required] public PanaudojimoSritis? PanaudojimoSritis { get; set; }
}
