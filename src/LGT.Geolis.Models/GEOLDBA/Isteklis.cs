namespace LGT.Geolis.Geoldba;
[Table(name: "ISTEKLIAI", Schema = "GEOLDBA")]
public class Isteklis
{
  [Key]
  [Column("IST_KODAS")]
  public Int64 ID { get; set; } //IST_KODAS->NUMBER(6,0)->No->->1->Unikalus (aut.gen.) kodas, skirtas ry?iui su grafika.
  [Column("IST_ISTK_KATEGORIJA")]
  public string IST_ISTK_KATEGORIJA { get; set; } = default!; //IST_ISTK_KATEGORIJA->VARCHAR2(10 BYTE)->No->->2->Kategorijos pavadinimas.
	[Column("IST_ITD_KODAS")]
  public Int64? IST_ITD_KODAS { get; set; } //IST_ITD_KODAS->NUMBER(4,0)->Yes->->3->Išteklių tvirtinimo dok.kodas (rysys su IST_TVIRT_DOK) angliavandeniliu ir poz.vandens telkiniams. Nerudinems isk. dokumentai fiksuojami lenteleje IST_DOK.
  [Column("IST_MATOVNT_TRUMP")]
  public string? IST_MATOVNT_TRUMP { get; set; } //IST_MATOVNT_TRUMP->VARCHAR2(10 BYTE)->Yes->->4->pirminis raktas
  [Column("IST_KIEKIS")]
  public decimal? IST_KIEKIS { get; set; } //IST_KIEKIS->NUMBER(10,3)->Yes->->5->Patvirtintas geologiniu i?tekli? kiekis t.kub.m.
  [Column("IST_TELK_KODAS")]
  public int? TelkinysID { get; set; } //IST_TELK_KODAS->NUMBER(5,0)->Yes->->6->Unikalus, aut. gen. kodas, skirtas ry?iui su grafika.
  public Telkinys? Telkinys { get;set;}
  [Column("IST_AGS_SL_NR")]
  public int SluoksnisID { get; set; } //IST_AGS_SL_NR->NUMBER(6,0)->Yes->->7->Unikalus, automatiškai generuojamas kodas.
  public TelkinioSluoksnis? Sluoksnis { get;set;}
  [Column("IST_KIEKIS_T")]
  public decimal? IST_KIEKIS_T { get; set; } //IST_KIEKIS_T->NUMBER(10,3)->Yes->->8->
  [Column("IST_MATOVNT_T")]
  public string? IST_MATOVNT_T { get; set; } //IST_MATOVNT_T->VARCHAR2(10 BYTE)->Yes->->9->
  [Column("IST_PASTABA")]
  public string? Comment { get; set; } //IST_PASTABA->VARCHAR2(100 BYTE)->Yes->->10->
  [Column("IST_GALIOJA_NUO")]
  public DateTime? IST_GALIOJA_NUO { get; set; } //IST_GALIOJA_NUO->DATE->Yes->->11->
  [Column("IST_GALIOJA_IKI")]
  public DateTime? IST_GALIOJA_IKI { get; set; } //IST_GALIOJA_IKI->DATE->Yes->->12->
  [Column("IST_GAV_KIEKIS")]
  public decimal? IST_GAV_KIEKIS { get; set; } //IST_GAV_KIEKIS->NUMBER(10,3)->Yes->->13->Patvirtintas isgaunamu Išteklių kiekis t.kub.m
  [Column("IST_GAV_KIEKIS_T")]
  public decimal? IST_GAV_KIEKIS_T { get; set; } //IST_GAV_KIEKIS_T->NUMBER(10,3)->Yes->->14->Patvirtintas isgaunamu Išteklių kiekis t.tonu
}
