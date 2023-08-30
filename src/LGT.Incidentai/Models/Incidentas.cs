namespace LGT.Incidentai.Models;
public class Incidentas : IIDed<int>
{
  public int ID { get; set; }

  public ICollection<CommentT<Incidentas>> Comments { get; set; }


  public string Grupė { get;set;}
  public string Pogrūpis { get;set;}
  public string Poveikio_Kategorija { get; set; }
  
  public TrumpasApibūdinimas TrumpasApibūdinimas { get; set; }
}
public class TrumpasApibūdinimas : Owned
{
  [Column("TrumpasApibudinimas")]  public string Desc { get; set; }
  public DateTime NustatytasAt { get; set; }
  public DateTime AtsitikoAt { get; set; }
  public string IncidentoŠalinimoTvarka { get; set; }
  public bool? IncidentoŠalinimoTvarka_IsPriority { get; set; }
}