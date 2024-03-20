namespace LGT.Geolis.INV;
[Table(name: "INV_IR_REMONTAS", Schema = "INV")]
public class Remontas
{
  [Key]
  [Column("REM_NR")] public string ID { get; set; } = default!; //REM_NR->VARCHAR2(15 BYTE)->No->->8->
  [Column("REM_IR_INV_NR")] public string IrangaID { get; set; } = default!; //REM_IR_INV_NR->VARCHAR2(10 BYTE)->No->->1->
  [Required] public Iranga? Iranga { get; set; }
  [Column("REM_PVM_SASK")] public string? REM_PVM_SASK { get; set; } //REM_PVM_SASK->VARCHAR2(20 BYTE)->Yes->->3->
  [Column("REM_PASTABOS")] public string? REM_PASTABOS { get; set; } //REM_PASTABOS->VARCHAR2(200 BYTE)->Yes->->4->
  [Column("REM_DATA_NUO")] public DateTime DateSince { get; set; } //REM_DATA_NUO->DATE->No->->2->
  [Column("REM_DATA_IKI")] public DateTime? DateUntil { get; set; } //REM_DATA_IKI->DATE->Yes->->5->
  [Column("REM_GEDIMAS")] public string? REM_GEDIMAS { get; set; } //REM_GEDIMAS->VARCHAR2(250 BYTE)->Yes->->7->
  [Column("REM_KAINA_EUR")] public decimal? PriceEur { get; set; } //REM_KAINA_EUR->NUMBER(6,2)->Yes->->9->
  [Column("REM_KAINA")] public decimal? PriceLT { get; set; } //REM_KAINA->NUMBER(6,2)->Yes->->6->
}
