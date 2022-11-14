namespace LGT.Web.Authorization;
[Flags]
public enum IntranetEnum : Int64
{
  None = 0,
  MessagesEdit = 1,
  PagesEdit = 2,
  FilesUpload = 4,
  FilesDelete = 8,
  ArticlesEdit = 16,
  All = Int64.MaxValue
}
public static class IntranetPolicy
{
  public static AuthInfo Info = new AuthInfo(typeof(IntranetEnum), "intranet", "Intranet");
  public const string Prefix = "intranet";
  public static bool IsValidPolicyName(string? policyName)
  {
    return policyName != null && policyName.StartsWith(Prefix, StringComparison.OrdinalIgnoreCase);
  }
  public static string GeneratePolicyNameFor(IntranetEnum permissions)
  {
    if (permissions == IntranetEnum.None)
      return string.Empty;
    return $"{Prefix}{(Int64)permissions}";
  }
  public static IntranetEnum GetPermissionsFrom(string policyName)
  {
    var permissionsValue = Int64.Parse(policyName[Prefix.Length..]!);
    return (IntranetEnum)permissionsValue;
  }
  public static IntranetEnum NumberToEnum(string number)
  {
    Int64 value = Int64.Parse(number);
    return NumberToEnum(value);
  }
  public static IntranetEnum NumberToEnum(Int64 value)
  {
    return (IntranetEnum)value;
  }
}