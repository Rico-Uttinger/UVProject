public class MaxExposure
{
    public int Id { get; private set; }
    public int SkinType { get; private set; }
    public int Minutes { get; private set; }
    public int UvIndex { get; private set; }

    public MaxExposure(int skinType, int minutes, int uvIndex)
    {
        this.SkinType = skinType;
        this.Minutes = minutes;
        this.UvIndex = uvIndex;
    }
}