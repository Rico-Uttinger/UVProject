public class Exposure
{
    public int Id { get; private set; }
    public int Minutes { get; private set; }
    public int UvIndex { get; private set; }
    public DateTime BeginTime { get; private set; }

    public Exposure(int minutes, int uvIndex, DateTime beginTime)
    {
        this.Minutes = minutes;
        this.UvIndex = uvIndex;
        this.BeginTime = beginTime;
    }
}