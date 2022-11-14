using System.Runtime.CompilerServices;

namespace LGT.Web.Authorization;
[Flags]
public enum GISEnum : Int64
{
  None = 0,
  All = Int64.MaxValue
}
public static class GISPolicy
{
  public static AuthInfo Info = new AuthInfo(typeof(GISEnum), "gis", "GIS");
  public const string Prefix = "gis";
  public static bool IsValidPolicyName(string? policyName)
  {
    return policyName != null && policyName.StartsWith(Prefix, StringComparison.OrdinalIgnoreCase);
  }
  public static string GeneratePolicyNameFor(GISEnum permissions)
  {
    if (permissions == GISEnum.None)
      return string.Empty;
    return $"{Prefix}{(Int64)permissions}";
  }
  public static GISEnum GetPermissionsFrom(string policyName)
  {
    var permissionsValue = Int64.Parse(policyName[Prefix.Length..]!);
    return (GISEnum)permissionsValue;
  }
  public static GISEnum NumberToEnum(string number)
  {
    Int64 value = Int64.Parse(number);
    return NumberToEnum(value);
  }
  public static GISEnum NumberToEnum(Int64 value)
  {
    return (GISEnum)value;
  }
}
