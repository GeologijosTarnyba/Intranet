using LGT.Geolis.Exports;
using LGT.Geolis;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Play;
internal static class Dialoger
{
  public static string? SaveDir { get; set; }
  public static async Task InteractiveSession(GeolisContext db)
  {
    do
    {
      Console.WriteLine("Pasirinkite tarp \"[]\" nurydytą kodą, kad atlikti funkciją.");
      WritePossibleChoices();
      string response = Console.ReadLine() ?? throw new ArgumentNullException();
      if (response == "exit")
        return;
      await HandleChoice(db, response);
    } while (true);
  }
  public static void WritePossibleChoices()
  {
    Console.WriteLine("[1] Telkinių schemų gręžinių išvedimas į failą.");
    Console.WriteLine("[2] Orgonogeninių schemų gręžinių išvedimas į failą.");
    Console.WriteLine("[exit] Baigti darbą.");
  }
  public static async Task<bool> HandleChoice(GeolisContext db, string choice)
  {
    switch (choice)
    {
      case "exit":
        throw new UnreachableException($"\"exit\" pasirinkimas neturėtų kviesti {nameof(HandleChoice)} metodo.");
      case "1":
        await Export(
          new GreziniaiExporter(db, "BRU_GREZINIAI"),
          $"{SaveDir}\\BRU_GREZINIAI.txt"
        );
        break;
      case "2":
        await Export(
          new GreziniaiExporter(db, "ORG_GREZINIAI"),
          $"{SaveDir}\\ORG_GREZINIAI.txt"
        );
        break;
      default:
        Console.WriteLine($"Nepalaikomas pasirinkimas \"{choice}\".");
        return false;
    }
    return true;
  }
  private static async Task Export(IFileExporter exporter, string outputPath)
  {
    exporter.PrintDebug = false;
    exporter.PrintData = false;
    exporter.PrintPogress = false;
    await exporter.ToFile(outputPath);
  }
}
