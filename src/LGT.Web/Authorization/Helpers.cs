namespace LGT.Web.Authorization;
public class AuthInfo
{
  public string Name { get; }
  public Type EnumType { get; }
  public string Prefix { get; }

  #region Constructors
  public AuthInfo(Type enumType, string prefix, string name)
  {
    this.EnumType = enumType;
    this.Prefix = prefix;
    this.Name = name;
  }
  #endregion
  public override string ToString() => this.Name;
}
