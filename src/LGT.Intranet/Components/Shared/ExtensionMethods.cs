public static class ExtensionMethods
{
  public static string LT(this DateTime t, bool ShowTime = false)
  {
    var format = (ShowTime) switch
    {
      (true) => "yyyy-MM-dd HH:mm",
      (false) => "yyyy-MM-dd"
    };
    return t.ToString(format);
  }
  public static string? LT(this DateTime? t, bool ShowTime = false) 
    => t?.LT(ShowTime);
}
