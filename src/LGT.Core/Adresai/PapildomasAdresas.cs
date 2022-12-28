namespace LGT.Core.Adresai;
[Table(name: "ADR_PAPILDOMI", Schema = "ADRESAI")]
public class PapildomasAdresas
{
  [Key]
  [Column("PAP_ID")]
  public string ID { get; set; } //PAP_ID->VARCHAR2(20 BYTE)->No->->1->
  [Column("PAP_TIPAS")]
  public string DefinitionID { get; set; } //PAP_TIPAS->VARCHAR2(10 BYTE)->No->->2->
  public PapildomasAdresasDefinition Definition { get; set; }
  [Column("PAP_PAVADINIMAS")]
  public string Name { get; set; } //PAP_PAVADINIMAS->VARCHAR2(40 BYTE)->No->->3->
  [Column("PAP_ATV_ID")]
  public string ATVID { get; set; } //PAP_ATV_ID->VARCHAR2(20 BYTE)->No->->4->
  public ATV ATV { get; set; }
}
