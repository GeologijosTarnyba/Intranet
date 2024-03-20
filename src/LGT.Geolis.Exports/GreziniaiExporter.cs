using LGT.Geolis.Geoldba;
using Microsoft.EntityFrameworkCore;

namespace LGT.Geolis.Exports;
public class GreziniaiExporter(GeolisContext geolis, string grafikosTipasId) : IFileExporter
{
  public GeolisContext Geolis { get; init; } = geolis;
  public string GrafikosTipasId { get; init; } = grafikosTipasId;
  private const string sep = "\t";
  public bool PrintPogress { get; set; } = true;
  public bool PrintData { get; set; } = false;
  public bool PrintDebug { get; set; } = false;

  public async Task ToFile(string path)
  {
    if (await V2(path))
    {
      Console.WriteLine($"Sėkmingai išeksportuota į {path}");
      Console.WriteLine(string.Empty);
    }
  }
  private async Task<bool> V2(string path)
  {
    var keys = await Geolis.Set<GIS_GRAFIKOS_ATRIBUTAI>()
      .AsNoTracking()
      .Where(item => item.GG_GRAFIKOS_TIPAIId == this.GrafikosTipasId)
      .Select(item => new { item.Id, Name = item.GRA_PAVADINIMAS })
      .ToListAsync();
    var query = Geolis.Set<GIS_TELKINIU_SCHEMU_EOBJ>()
      .AsNoTracking()
      .Where(obj => obj.GG_GRAFIKOS_TIPASID == this.GrafikosTipasId)
      .Select(eobj => new {
        Telkinys = new {
          Id = eobj.GIS_TELKINIU_SCHEMU_SLUOKSNIS!.GIS_TELKINIO_SCHEMA!.TelkinysId
        },
        Schema = new {
          Name = eobj.GIS_TELKINIU_SCHEMU_SLUOKSNIS.GIS_TELKINIO_SCHEMA.TSC_SCHEMOS_PAVADINIMAS,
          Metai = eobj.GIS_TELKINIU_SCHEMU_SLUOKSNIS.GIS_TELKINIO_SCHEMA.TSC_SCHEMOS_METAI,
          PateikimoData = eobj.GIS_TELKINIU_SCHEMU_SLUOKSNIS.GIS_TELKINIO_SCHEMA.TSC_PATEIKIMO_DATA,
        },
        Sluoksnis = new {
          Id = eobj.GIS_TELKINIU_SCHEMU_SLUOKSNIS.Id,
          Definition = new {
            Name = eobj.GIS_TELKINIU_SCHEMU_SLUOKSNIS.GIS_SCHEM_SLUOKSNIS!.Name
          }
        },
        Id = eobj.Id,
        X = eobj.XY!.X,
        Y = eobj.XY!.Y,
        GrafikosAtributai = eobj.GrafikosAtributai!.Select(grafAtr => new {
          Value = grafAtr.ToString(),
          Definition = new {
            Id = grafAtr.GIS_GRAFIKOS_ATRIBUTAIId
          }
        })
      });

    if (this.PrintDebug)
    {
      Console.WriteLine(query.ToQueryString());
    }
    var eobjs = await query.ToListAsync();
    if (eobjs.Count == 0)
    {
      Console.WriteLine("Objektų nerasta - eksportavimas nepavyko.");
      return false;
    }
    var count = eobjs.Count;
    Console.WriteLine($"Rasta {count} objektų, vyksta eksportavimas - neuždarykite programos lango.");
    int i = 1;
    using StreamWriter writer = new(path);
    writer.WriteLine($"TELK KODAS{sep}SCHEMOS PAVADINIMAS{sep}SCHEMOS METAI{sep}PATEIKIMO DATA{sep}SLUOKSNIO PAVADINIMAS{sep}OBJ_ID{sep}KOORD_X{sep}KOORD_Y{sep}" + string.Join(sep, keys.Select(item => item.Name)));
    foreach (var eobj in eobjs)
    {
      if (this.PrintPogress)
      {
        Console.WriteLine($"{i++}/{count}");
      }
      string sujungtosGrafiniuAtributuReiksmes = string.Join(sep, keys.Select(key => eobj.GrafikosAtributai.FirstOrDefault(item => item.Definition.Id == key.Id)?.Value ?? "<klaida>"));
      var row = $"{eobj.Telkinys.Id}{sep}" +
        $"{eobj.Schema.Name}{sep}" +
        $"{eobj.Schema.Metai}{sep}" +
        $"{eobj.Schema.PateikimoData}{sep}" +
        $"{eobj.Sluoksnis.Definition.Name}{sep}" +
        $"{eobj.Id}{sep}" +
        $"{eobj.X}{sep}" +
        $"{eobj.Y}{sep}" +
        sujungtosGrafiniuAtributuReiksmes
      ;
      writer.WriteLine(row);
      if (this.PrintData)
      {
        Console.WriteLine(row);
      }
    }
    return true;
  }
}
