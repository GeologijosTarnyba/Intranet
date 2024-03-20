namespace Play;
internal class Helpers
{
  public static string ReadStringOrThrow(string message, string errorMessage)
  {
    Console.WriteLine(message);
    var enteredValue = Console.ReadLine();
    if (string.IsNullOrEmpty(enteredValue))
    {
      throw new Exception(errorMessage);
    }
    return enteredValue;
  }
}
