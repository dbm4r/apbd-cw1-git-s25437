using System.Linq;

public class StatisticsHelper
{
    public static double CalculateAverage(int[] values)
    {
        return values.Average();
    }
    public static int CalculateMin(int[] values)
    {
    return values.Min();
    }

    public static int CalculateMax(int[] values)
    {
        return values.Max();
    }
}
