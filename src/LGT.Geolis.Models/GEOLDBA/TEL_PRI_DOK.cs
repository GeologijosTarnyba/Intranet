namespace LGT.Geolis.Geoldba;
[Table(name: "TEL_PRI_DOK", Schema = "GEOLDBA")]
public class TEL_PRI_DOK
{
  [Required] public Telkinys? Telkinys { get; set; }
  [Column("TPL_TELK_KODAS")] public int TelkinysID { get; set; }  // Unikalus, aut. gen. kodas, skirtas ry?iui su grafika.
  [Required] public JOL.J_DOKUMENTAI? J_DOKUMENTAI { get; set; }
  [Column("TPL_LEID_DOK_ID")] public Int64 J_DOKUMENTAIID { get; set; }  // Dirbtinis kodas,automati?kai generuojamas.
}
