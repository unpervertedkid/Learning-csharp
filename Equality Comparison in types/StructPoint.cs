namespace Equality_Comparison;

public struct StructPoint
{
    public int XPoint { get; set; }
    public int YPoint { get; set; }

    public static bool operator ==(StructPoint a, StructPoint b) => a.XPoint == b.XPoint && a.YPoint == b.YPoint;
    public static bool operator !=(StructPoint a, StructPoint b) => a.XPoint != b.XPoint && a.YPoint != b.YPoint;
}