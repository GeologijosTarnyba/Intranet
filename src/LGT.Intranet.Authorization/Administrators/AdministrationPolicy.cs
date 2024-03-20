namespace LGT.Intranet.Authorization;

[Flags]
public enum AdminRights : Int64
{
  None = 0,
  EditUsers = 1,
  Incidentai = 2,
  All = Int64.MaxValue
}
public static class AdministrationPolicy
{
  public const string Prefix = "admin";
  public static readonly AuthInfo Info = new(typeof(AdminRights), Prefix, "Admin");
  //public static Type EnumType => typeof(AuthEnum);
  public static bool IsValidPolicyName(string? policyName) => 
    policyName != null 
    && policyName.StartsWith(Prefix, StringComparison.OrdinalIgnoreCase);
  public static string GeneratePolicyNameFor(AdminRights permissions)
  {
    return permissions switch 
    {
      AdminRights.None => string.Empty,
      _ => $"{Prefix}{(long)permissions}"
    };
  }
  public static AdminRights GetPermissionsFrom(string policyName)
  {
    var permissionsValue = Int64.Parse(policyName[Prefix.Length..]!);
    return (AdminRights)permissionsValue;
  }
  public static AdminRights NumberToEnum(string number)
  {
    Int64 value = Int64.Parse(number);
    return NumberToEnum(value);
  }
  public static AdminRights NumberToEnum(Int64 value) 
    => (AdminRights)value;
}
