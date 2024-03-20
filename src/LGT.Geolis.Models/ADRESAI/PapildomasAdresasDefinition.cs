namespace LGT.Geolis.Adresai;
[Table(name: "ADR_PAP_TIPAI", Schema = "ADRESAI")]
public class PapildomasAdresasDefinition
{
  public ICollection<PapildomasAdresas>? Instances { get; set; }

  [Key]
  [Column("PAPT_ID")]
  public string PAPT_ID { get; set; } = default!; //PAPT_ID->VARCHAR2(10 BYTE)->No->->1->
	[Column("PAPT_PAV")]
  public string Name { get; set; } = default!; //PAPT_PAV->VARCHAR2(40 BYTE)->No->->2->
}
