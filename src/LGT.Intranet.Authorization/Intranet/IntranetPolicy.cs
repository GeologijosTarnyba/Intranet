namespace LGT.Intranet.Authorization;
[Flags]
public enum IntranetRights: Int64
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
  public const string Prefix = "intranet";
  public static readonly AuthInfo Info = new(typeof(IntranetRights), Prefix, "Intranet");
  public static bool IsValidPolicyName(string? policyName) =>
    policyName != null
    && policyName.StartsWith(Prefix, StringComparison.OrdinalIgnoreCase)
  ;
  public static string GeneratePolicyNameFor(IntranetRights permissions) =>
    permissions switch {
      IntranetRights.None => string.Empty,
      _ => $"{Prefix}{(long)permissions}"
    };

  public static IntranetRights GetPermissionsFrom(string policyName)
  {
    var permissionsValue = Int64.Parse(policyName[Prefix.Length..]!);
    return (IntranetRights)permissionsValue;
  }
  public static IntranetRights NumberToEnum(string number)
  {
    Int64 value = Int64.Parse(number);
    return NumberToEnum(value);
  }
  public static IntranetRights NumberToEnum(Int64 value) 
    => (IntranetRights)value;
}