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
  {
    if(t == null)
      return null;
    return t.Value.LT(ShowTime);
  }
}