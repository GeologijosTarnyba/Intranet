//namespace LGT.Core.Inv;
//[Table(name: "TOAD_PLAN_TABLE", Schema = "INV")]
//public class TOAD_PLAN_TABLE
//{
//  [NotMapped] // TODO: Map
//  [Column("STATEMENT_ID")]
//  public string? STATEMENT_ID { get; set; } //STATEMENT_ID->VARCHAR2(30 BYTE)->Yes->->1->
//  [NotMapped] // TODO: Map
//  [Column("PLAN_ID")]
//  public Int64? PLAN_ID { get; set; } //PLAN_ID->NUMBER->Yes->->2->
//  [NotMapped] // TODO: Map
//  [Column("TIMESTAMP")]
//  public DateTime? TIMESTAMP { get; set; } //TIMESTAMP->DATE->Yes->->3->
//  [NotMapped] // TODO: Map
//  [Column("REMARKS")]
//  public string? REMARKS { get; set; } //REMARKS->VARCHAR2(4000 BYTE)->Yes->->4->
//  [NotMapped] // TODO: Map
//  [Column("OPERATION")]
//  public string? OPERATION { get; set; } //OPERATION->VARCHAR2(30 BYTE)->Yes->->5->
//  [NotMapped] // TODO: Map
//  [Column("OPTIONS")]
//  public string? OPTIONS { get; set; } //OPTIONS->VARCHAR2(255 BYTE)->Yes->->6->
//  [NotMapped] // TODO: Map
//  [Column("OBJECT_NODE")]
//  public string? OBJECT_NODE { get; set; } //OBJECT_NODE->VARCHAR2(128 BYTE)->Yes->->7->
//  [NotMapped] // TODO: Map
//  [Column("OBJECT_OWNER")]
//  public string? OBJECT_OWNER { get; set; } //OBJECT_OWNER->VARCHAR2(30 BYTE)->Yes->->8->
//  [NotMapped] // TODO: Map
//  [Column("OBJECT_NAME")]
//  public string? OBJECT_NAME { get; set; } //OBJECT_NAME->VARCHAR2(30 BYTE)->Yes->->9->
//  [NotMapped] // TODO: Map
//  [Column("OBJECT_ALIAS")]
//  public string? OBJECT_ALIAS { get; set; } //OBJECT_ALIAS->VARCHAR2(65 BYTE)->Yes->->10->
//  [NotMapped] // TODO: Map
//  [Column("OBJECT_INSTANCE")]
//  public Int64? OBJECT_INSTANCE { get; set; } //OBJECT_INSTANCE->NUMBER(38,0)->Yes->->11->
//  [NotMapped] // TODO: Map
//  [Column("OBJECT_TYPE")]
//  public string? OBJECT_TYPE { get; set; } //OBJECT_TYPE->VARCHAR2(30 BYTE)->Yes->->12->
//  [NotMapped] // TODO: Map
//  [Column("OPTIMIZER")]
//  public string? OPTIMIZER { get; set; } //OPTIMIZER->VARCHAR2(255 BYTE)->Yes->->13->
//  [NotMapped] // TODO: Map
//  [Column("SEARCH_COLUMNS")]
//  public Int64? SEARCH_COLUMNS { get; set; } //SEARCH_COLUMNS->NUMBER->Yes->->14->
//  [NotMapped] // TODO: Map
//  [Column("ID")]
//  public Int64? ID { get; set; } //ID->NUMBER(38,0)->Yes->->15->
//  [NotMapped] // TODO: Map
//  [Column("PARENT_ID")]
//  public Int64? PARENT_ID { get; set; } //PARENT_ID->NUMBER(38,0)->Yes->->16->
//  [NotMapped] // TODO: Map
//  [Column("DEPTH")]
//  public Int64? DEPTH { get; set; } //DEPTH->NUMBER(38,0)->Yes->->17->
//  [NotMapped] // TODO: Map
//  [Column("POSITION")]
//  public Int64? POSITION { get; set; } //POSITION->NUMBER(38,0)->Yes->->18->
//  [NotMapped] // TODO: Map
//  [Column("COST")]
//  public Int64? COST { get; set; } //COST->NUMBER(38,0)->Yes->->19->
//  [NotMapped] // TODO: Map
//  [Column("CARDINALITY")]
//  public Int64? CARDINALITY { get; set; } //CARDINALITY->NUMBER(38,0)->Yes->->20->
//  [NotMapped] // TODO: Map
//  [Column("BYTES")]
//  public Int64? BYTES { get; set; } //BYTES->NUMBER(38,0)->Yes->->21->
//  [NotMapped] // TODO: Map
//  [Column("OTHER_TAG")]
//  public string? OTHER_TAG { get; set; } //OTHER_TAG->VARCHAR2(255 BYTE)->Yes->->22->
//  [NotMapped] // TODO: Map
//  [Column("PARTITION_START")]
//  public string? PARTITION_START { get; set; } //PARTITION_START->VARCHAR2(255 BYTE)->Yes->->23->
//  [NotMapped] // TODO: Map
//  [Column("PARTITION_STOP")]
//  public string? PARTITION_STOP { get; set; } //PARTITION_STOP->VARCHAR2(255 BYTE)->Yes->->24->
//  [NotMapped] // TODO: Map
//  [Column("PARTITION_ID")]
//  public Int64? PARTITION_ID { get; set; } //PARTITION_ID->NUMBER(38,0)->Yes->->25->
//  [NotMapped] // TODO: Map
//  [Column("OTHER")]
//  public else? OTHER { get; set; } //OTHER->LONG->Yes->->26->
// // TODO: Map
//[Column("DISTRIBUTION")]
//public string? DISTRIBUTION { get; set; } //DISTRIBUTION->VARCHAR2(30 BYTE)->Yes->->27->
// // TODO: Map
//[Column("CPU_COST")]
//public Int64? CPU_COST { get; set; } //CPU_COST->NUMBER(38,0)->Yes->->28->
// // TODO: Map
//[Column("IO_COST")]
//public Int64? IO_COST { get; set; } //IO_COST->NUMBER(38,0)->Yes->->29->
// // TODO: Map
//[Column("TEMP_SPACE")]
//public Int64? TEMP_SPACE { get; set; } //TEMP_SPACE->NUMBER(38,0)->Yes->->30->
// // TODO: Map
//[Column("ACCESS_PREDICATES")]
//public string? ACCESS_PREDICATES { get; set; } //ACCESS_PREDICATES->VARCHAR2(4000 BYTE)->Yes->->31->
// // TODO: Map
//[Column("FILTER_PREDICATES")]
//public string? FILTER_PREDICATES { get; set; } //FILTER_PREDICATES->VARCHAR2(4000 BYTE)->Yes->->32->
// // TODO: Map
//[Column("PROJECTION")]
//public string? PROJECTION { get; set; } //PROJECTION->VARCHAR2(4000 BYTE)->Yes->->33->
// // TODO: Map
//[Column("TIME")]
//public Int64? TIME { get; set; } //TIME->NUMBER(38,0)->Yes->->34->
// // TODO: Map
//[Column("QBLOCK_NAME")]
//public string? QBLOCK_NAME { get; set; } //QBLOCK_NAME->VARCHAR2(30 BYTE)->Yes->->35->
// // TODO: Map
//[Column("OTHER_XML")]
//public else? OTHER_XML { get; set; } //OTHER_XML->CLOB->Yes->->36->
//}