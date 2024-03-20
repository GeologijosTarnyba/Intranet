namespace LGT.Geolis.Geoldba;
[Table(name: "PANAUDOJIMO_SRITYS", Schema = "GEOLDBA")]
public class PanaudojimoSritis
{
  [Key]
  [Column("PNS_KODAS")] public string ID { get; set; } = default!; //PNS_KODAS->VARCHAR2(10 BYTE)->No->->1->
	[Column("PNS_PNS_KODAS")] public string? ParentID { get; set; } //PNS_PNS_KODAS->VARCHAR2(10 BYTE)->Yes->->2->
  public PanaudojimoSritis? Parent { get; set; }
  public ICollection<PanaudojimoSritis>? Children { get; set; }
  [Column("PNS_SRITIS")]
  public string Name { get; set; } = default!; //PNS_SRITIS->VARCHAR2(100 BYTE)->No->->3->
	/// <summary>
	/// Teisės aktais nustatomas kodas
	/// </summary>
	[Column("PNS_REG_KODAS")]
  public string PNS_REG_KODAS { get; set; } = default!; //PNS_REG_KODAS->VARCHAR2(10 BYTE)->No->->4->
	[NotMapped]
  [Column("PNS_INSPIRE")]
  public string? PNS_INSPIRE { get; set; } //PNS_INSPIRE->VARCHAR2(100 BYTE)->Yes->->5->
  public override string ToString() => $"{this.Name} [{this.ID}]";
}
