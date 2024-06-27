namespace Play;
internal class ArgsInterpreter
{
  private readonly string username;
  private readonly string password;
  public string Path { get; set; }
  public List<string> Choices { get; set; } = [];
  public string ConnectionString => $"User Id={username};Password={password};Data Source=geolis2:1521/geolis2";
  public ArgsInterpreter(string[] args)
  {
    for (int i = 0; i < args.Length; i++)
    {
      if (args[i].StartsWith('-'))
      {
        if (args.Length <= i + 1) // yra parametras, bet nėra sekančio argument (jo reikšmės)
        {
          throw new Exception($"Nenurodyta parametro {args[i]} reikšmė.");
        }
        switch (args[i])
        {
          case "-u":
          case "--username":
            this.username = args[i + 1];
            break;
          case "-p":
          case "-pw":
          case "--password":
            this.password = args[i + 1];
            break;
          case "-path":
            this.Path = args[i + 1];
            break;
        }
        i++; // Skip next argument
      }
      else
      {
        this.Choices.Add(args[i]);
      }
    }
    this.username ??= Helpers.ReadStringOrThrow("Oracle vartotojo vardas", "Username not provided");
    this.password ??= Helpers.ReadStringOrThrow($"Oracle vartotojo \"{username}\" slaptažodis", "Password not provided");
    this.Path ??= "\\\\granitas\\visi\\visi\\qgis\\dumps";
  }
}
