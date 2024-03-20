namespace LGT.Geolis;
/// <summary>
/// hakas tašką padaryt iš SDO_GEOMETRY
/// </summary>
/// <typeparam name="TId"></typeparam>
public class XY<TId>
{
  public TId Id { get; set; } = default!;
  public float X { get; set; }
  public float Y { get; set; }
}
