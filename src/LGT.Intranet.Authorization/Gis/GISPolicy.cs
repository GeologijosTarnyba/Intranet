using System.Runtime.CompilerServices;

namespace LGT.Intranet.Authorization;
[Flags]
public enum GISRights : Int64
{
  None = 0,
  Telkiniai = 1,
  Leidimai = 2,
  Greziniai = 4,
  Greziniai_tikstatistika = 8,
  AsmensDuomenys = (Int64)1 << 60,
  All = Int64.MaxValue
}
public static class GISPolicy
{
  public const string Prefix = "gis";
  public static readonly AuthInfo Info = new(typeof(GISRights), Prefix, "GIS");
  public static bool IsValidPolicyName(string? policyName) => 
    policyName != null
    && policyName.StartsWith(Prefix, StringComparison.OrdinalIgnoreCase);
  public static string GeneratePolicyNameFor(GISRights permissions)
  {
    return permissions switch 
    {
      GISRights.None => string.Empty,
      _ => $"{Prefix}{(long)permissions}"
    };
  }
  public static GISRights GetPermissionsFrom(string policyName)
  {
    var permissionsValue = Int64.Parse(policyName[Prefix.Length..]!);
    return (GISRights)permissionsValue;
  }
  public static GISRights NumberToEnum(string number)
  {
    Int64 value = Int64.Parse(number);
    return NumberToEnum(value);
  }
  public static GISRights NumberToEnum(Int64 value) => (GISRights)value;
}
