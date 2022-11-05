public class Convert
{
    int minutes;
    public Convert(int minutes)
    {
        this.minutes = minutes;
    }
    public int ConvertToMinutes()
    {
        return minutes*60;
    }
}