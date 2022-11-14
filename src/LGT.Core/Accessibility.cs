namespace LGT.Core;
public enum Accessibility : Int64
{
  Private      = 0,
  IsAccessible = 0b00000000_00000000_00000000_00000001,
  IsListed     = 0b00000000_00000000_00000000_00000011,
}
