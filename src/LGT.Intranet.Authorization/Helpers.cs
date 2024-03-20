namespace LGT.Intranet.Authorization;
public class AuthInfo(Type enumType, string prefix, string name)
{
  public Type EnumType { get; } = enumType;
  public string Prefix { get; } = prefix;
  public string Name { get; } = name;

  public override string ToString() => this.Name;
}
