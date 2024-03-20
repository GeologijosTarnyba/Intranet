namespace Play;

using LGT.Geolis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

internal class Program
{
  public static async Task Main(string[] args)
  {
    var argsChoices = new ArgsInterpreter(args);
    IServiceCollection services = new ServiceCollection();
    var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
    services.AddDbContext<GeolisContext>(item => item.UseOracle(argsChoices.ConnectionString));
    var provider = services.BuildServiceProvider();
    var db = provider.GetRequiredService<GeolisContext>();
    if (!db.Database.CanConnect())
    {
      Console.WriteLine("Nepavyko prisijungti prie geolis DB");
      Console.WriteLine("Press any key to exit.");
      Console.Read();
      return;
    }
    if (argsChoices.Choices.Count > 0)
    {
      Dialoger.WritePossibleChoices();
      foreach (var choice in argsChoices.Choices)
      {
        Console.WriteLine(choice);
        if (choice == "exit")
          return;
        await Dialoger.HandleChoice(db, choice);
      }
    }
    await Dialoger.InteractiveSession(db);
  }
}
