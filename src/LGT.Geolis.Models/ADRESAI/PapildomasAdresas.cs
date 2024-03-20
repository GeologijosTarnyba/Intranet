namespace LGT.Geolis.Adresai;
[Table(name: "ADR_PAPILDOMI", Schema = "ADRESAI")]
public class PapildomasAdresas
{
  [Key]
  [Column("PAP_ID")]
  public string ID { get; set; } = default!; //PAP_ID->VARCHAR2(20 BYTE)->No->->1->
	[Column("PAP_TIPAS")]
  public string DefinitionID { get; set; } = default!; //PAP_TIPAS->VARCHAR2(10 BYTE)->No->->2->
	[Required] public PapildomasAdresasDefinition? Definition { get; set; }
  [Column("PAP_PAVADINIMAS")]
  public string Name { get; set; } = default!; //PAP_PAVADINIMAS->VARCHAR2(40 BYTE)->No->->3->
	[Column("PAP_ATV_ID")]
  public string ATVID { get; set; } = default!; //PAP_ATV_ID->VARCHAR2(20 BYTE)->No->->4->
	[Required] public ATV? ATV { get; set; }
}
