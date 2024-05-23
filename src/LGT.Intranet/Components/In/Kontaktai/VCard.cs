using Microsoft.EntityFrameworkCore;

namespace LGT.Intranet.Components.In.Kontaktai;

public static class VCard
{
  public static async Task<string> vCardText(LGT.Kontaktai.KontaktaiContext db, string orgId)
  {
    var now = DateTime.Now;
    var xs = await db.Set<LGT.Kontaktai.Models.Darbuotojas>()
    .Where(uoj => uoj.DarbovieteId == orgId)
    .Where(uoj => uoj.Until == null || uoj.Until > now)
    .Select(uoj => new {
      ORG = uoj.Darboviete!.Name,
      Title = uoj.Lytis == LGT.Kontaktai.Models.Lytys.Moteris ? uoj.Etatas.Name.Vardininke : uoj.Etatas.Name.Vardininkas,
      FN = uoj.FullName,
      Cell = uoj.Tel1,
      Voice = uoj.Tel2,
      Email = uoj.Email,
    })
    .ToListAsync();
    return string.Join("\n", xs.Select(uoj =>
      $"BEGIN:VCARD\nVERSION:2.1\n{X("ORG", uoj.ORG)}{X("TITLE", uoj.Title)}{X("FN", uoj.FN)}{X("TEL;cell", uoj.Cell )}{X("TEL;voice", uoj.Voice)}{X("EMAIL;work", uoj.Email)}END:VCARD"
    ))
      ;
  }
  private static string? X(string key, string? value)
  {
    if(value == null)
      return null;
    return $"{key}:{value}\n";
  }
}
