namespace Equality_Comparison;

public struct RecordPoint
{
    public int XPoint { get; set; }
    public int YPoint { get; set; }

    public static bool operator ==(RecordPoint a, RecordPoint b) => a.XPoint == b.XPoint && a.YPoint == b.YPoint;
    public static bool operator !=(RecordPoint a, RecordPoint b) => a.XPoint != b.XPoint && a.YPoint != b.YPoint;
}