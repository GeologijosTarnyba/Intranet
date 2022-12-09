namespace LGT.Core.Geoldba;

[Table(name: "GAV_SKL", Schema = "GEOLDBA")]
public class GavybosSklypas
{
  #region Views
  //public ICollection<Views.W_ZGR_MARKSEID_PLANAI> W_ZGR_MARKSEID_PLANAI { get; set; }
  #endregion
  public ICollection<ZGRLGavybosObjektas> ZGRLGavybosObjektai { get; set; }
  public ICollection<NER_GAV_KETV> NER_GAV_KETVs { get; set; }

  [Key][Column(name: "GSKL_KODAS")] public int ID { get; set; } //GSKL_KODAS->NUMBER(6,0)->No->->1->Kasybos sklype esantis "geologinių" išteklių kiekis
  [Column(name: "GSKL_TELK_KODAS")] public int TelkinysID { get; set; } //GSKL_TELK_KODAS->NUMBER(5,0)->No->->2->Unikalus, aut. gen. kodas, skirtas ry?iui su grafika.
  public Telkinys Telkinys { get; set; }
  #region GSKL_LEIDI_NR - Leidimas
  // UŽKOMENTUOTA NES NĖRA NEI VIENO, ir laukų tipai nesutampa. Neaišku kam skirtas GSKL_LEID_NR
  //[Column(name: "GSKL_LEIDI_NR")] // visada null duombazėje
  //public string? LeidimasID { get; set; } //GSKL_LEIDI_NR->VARCHAR2(15 BYTE)->Yes->->5->Leidimo registracijos numeris
  //public Leidimas? Leidimas { get; set; }
  #endregion
  //[Column(name: "GSKL_NUMERIS")]public string GSKL_NUMERIS { get; set; } //GSKL_NUMERIS->VARCHAR2(70 BYTE)->No->->3->Sklypo numeris/pavadinimas telkinyje.
  //[Column(name: "GSKL_PLOTAS")]public decimal GSKL_PLOTAS { get; set; } //GSKL_PLOTAS->NUMBER(5,1)->No->->4->Sklypo plotas, ha.
  //[Column(name: "GSKL_FAKT_KIEKIS")]public decimal? GSKL_FAKT_KIEKIS { get; set; } //GSKL_FAKT_KIEKIS->NUMBER(10,3)->Yes->->6->Išteklių kiekis kasybos sklype, patikslintas pagal naudojimo projektą
  //[Column(name: "GSKL_IST_KIEKIS")]public decimal? GSKL_IST_KIEKIS { get; set; } //GSKL_IST_KIEKIS->NUMBER(10,3)->Yes->->7->Kasybos sklype esantis "geologinių" išteklių kiekis
  //[Column(name: "GSKL_MAVNT")]public string? GSKL_MAVNT { get; set; } //GSKL_MAVNT->VARCHAR2(10 BYTE)->Yes->->8->Išteklių kiekio matavimo vnt.
  //[Column(name: "GSKL_IST_DATA")]public DateTime? GSKL_IST_DATA { get; set; } //GSKL_IST_DATA->DATE->Yes->->9->Gav. sklypo išteklių paskaičiavimo data
  //[Column(name: "GSKL_IST_KIEKIS_MAZASK")]public decimal? GSKL_IST_KIEKIS_MAZASK { get; set; } //GSKL_IST_KIEKIS_MAZASK->NUMBER(10,3)->Yes->->10->Kasybos sklype esantis "geologinis" mazaskaidziu durpiu išteklių kiekis
  //[Column(name: "GSKL_LEIDI_NR_OLD")]public string? GSKL_LEIDI_NR_OLD { get; set; } //GSKL_LEIDI_NR_OLD->VARCHAR2(15 BYTE)->Yes->->11->
  //[Column(name: "GSKL_FAKT_KIEKIS_MAZASK")]public decimal? GSKL_FAKT_KIEKIS_MAZASK { get; set; } //GSKL_FAKT_KIEKIS_MAZASK->NUMBER(10,3)->Yes->->12->Išteklių kiekis kasybos sklype, patikslintas pagal naudojimo projektą
  //[Column(name: "GSKL_FAKT_DATA")]public DateTime? GSKL_FAKT_DATA { get; set; } //GSKL_FAKT_DATA->DATE->Yes->->13->Išteklių kiekio kasybos sklype patikslinimo pagal naudojimo projektą data
  //[Column(name: "GSKL_GAV_KIEKIS")]public decimal? GSKL_GAV_KIEKIS { get; set; } //GSKL_GAV_KIEKIS->NUMBER(10,3)->Yes->->14->Gavybos sklype esantis IŠGAUNAMAS išteklių kiekis
  //[Column(name: "GSKL_GAV_KIEKIS_MAZASK")]public decimal? GSKL_GAV_KIEKIS_MAZASK { get; set; } //GSKL_GAV_KIEKIS_MAZASK->NUMBER(10,3)->Yes->->15->Gavybos sklype esantis IŠGAUNAMAS mažaskaidžių durpių išteklių kiekis
  //[Column(name: "GSKL_FAKT_KIEKIS_T")]public decimal? GSKL_FAKT_KIEKIS_T { get; set; } //GSKL_FAKT_KIEKIS_T->NUMBER(10,3)->Yes->->16->Kasybos sklype esantis išteklių kiekis, patikslintas pagal naudojimo projektą
  //[Column(name: "GSKL_IST_KIEKIS_T")]public decimal? GSKL_IST_KIEKIS_T { get; set; } //GSKL_IST_KIEKIS_T->NUMBER(10,3)->Yes->->17->Kasybos sklype esantis "geologinių" išteklių kiekis
  //[Column(name: "GSKL_IST_KIEKIS_MAZASK_T")]public decimal? GSKL_IST_KIEKIS_MAZASK_T { get; set; } //GSKL_IST_KIEKIS_MAZASK_T->NUMBER(10,3)->Yes->->18->Kasybos sklype esantis "geologinių" išteklių kiekis
  //[Column(name: "GSKL_FAKT_KIEKIS_MAZASK_T")]public decimal? GSKL_FAKT_KIEKIS_MAZASK_T { get; set; } //GSKL_FAKT_KIEKIS_MAZASK_T->NUMBER(10,3)->Yes->->19->Kasybos sklype esantis išteklių kiekis, patikslintas pagal naudojimo projektą
  //[Column(name: "GSKL_GAV_KIEKIS_T")]public decimal? GSKL_GAV_KIEKIS_T { get; set; } //GSKL_GAV_KIEKIS_T->NUMBER(10,3)->Yes->->20->Gavybos sklype esantis IŠGAUNAMAS išteklių kiekis
  //[Column(name: "GSKL_GAV_KIEKIS_MAZASK_T")]public decimal? GSKL_GAV_KIEKIS_MAZASK_T { get; set; } //GSKL_GAV_KIEKIS_MAZASK_T->NUMBER(10,3)->Yes->->21->Gavybos sklype esantis IŠGAUNAMAS išteklių kiekis
  //[Column(name: "GSKL_PROJ_DATA")]public DateTime? GSKL_PROJ_DATA { get; set; } //GSKL_PROJ_DATA->DATE->Yes->->22->Išteklių naudojimo projekto patvirtinimo data. Nuo 2012-02-22 ŽGR (Kristinos) prašymu.
  //[Column(name: "GSKL_PASTABA")]public string? GSKL_PASTABA { get; set; } //GSKL_PASTABA->VARCHAR2(1000 BYTE)->Yes->->23->
}