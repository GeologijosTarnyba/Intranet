using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGT.Geolis.INV;
[Table(name: "LGT_SUT_PRIEDAI2", Schema = "INV")]
public class LGT_SUT_PRIEDAI2
{
  [NotMapped] // TODO: Map
  [Column("LGTP_ID")]
  public int LGTP_ID { get; set; } //LGTP_ID->NUMBER(5,0)->No->->1->
  [NotMapped] // TODO: Map
  [Column("LGTP_LGTS_ID")]
  public int LGTP_LGTS_ID { get; set; } //LGTP_LGTS_ID->NUMBER(5,0)->No->->2->
  [NotMapped] // TODO: Map
  [Column("LGTP_LGTD_TRUMP")]
  public string? LGTP_LGTD_TRUMP { get; set; } //LGTP_LGTD_TRUMP->VARCHAR2(10 BYTE)->Yes->->3->
  [NotMapped] // TODO: Map
  [Column("LGTP_DAZNIS")]
  public string? LGTP_DAZNIS { get; set; } //LGTP_DAZNIS->VARCHAR2(30 BYTE)->Yes->->4->
  [NotMapped] // TODO: Map
  [Column("LGTP_FORMATAS")]
  public string? LGTP_FORMATAS { get; set; } //LGTP_FORMATAS->VARCHAR2(200 BYTE)->Yes->->5->
  [NotMapped] // TODO: Map
  [Column("LGTP_SALYGOS")]
  public string? LGTP_SALYGOS { get; set; } //LGTP_SALYGOS->VARCHAR2(200 BYTE)->Yes->->6->
  [NotMapped] // TODO: Map
  [Column("LGTP_APMOKEJIMAS")]
  public string? LGTP_APMOKEJIMAS { get; set; } //LGTP_APMOKEJIMAS->VARCHAR2(30 BYTE)->Yes->->7->
}
