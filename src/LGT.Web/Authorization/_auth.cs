namespace LGT.Web.Authorization;

[Flags]
public enum AdminRightsEnum : Int64
{
  None = 0,
  EditUsers = 1,
  All = Int64.MaxValue
}
public static class AuthPolicy
{
  public static AuthInfo Info = new AuthInfo(typeof(AdminRightsEnum), "admin", "Admin");
  //public static Type EnumType => typeof(AuthEnum);
  public const string Prefix = "admin";
  public static bool IsValidPolicyName(string? policyName)
  {
    return policyName != null && policyName.StartsWith(Prefix, StringComparison.OrdinalIgnoreCase);
  }
  public static string GeneratePolicyNameFor(AdminRightsEnum permissions)
  {
    if (permissions == AdminRightsEnum.None)
      return string.Empty;
    return $"{Prefix}{(Int64)permissions}";
  }
  public static AdminRightsEnum GetPermissionsFrom(string policyName)
  {
    var permissionsValue = Int64.Parse(policyName[Prefix.Length..]!);
    return (AdminRightsEnum)permissionsValue;
  }
  public static AdminRightsEnum NumberToEnum(string number)
  {
    Int64 value = Int64.Parse(number);
    return NumberToEnum(value);
  }
  public static AdminRightsEnum NumberToEnum(Int64 value)
  {
    return (AdminRightsEnum)value;
  }
}