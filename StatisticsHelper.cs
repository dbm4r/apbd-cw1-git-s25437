using System.Linq;

public class StatisticsHelper
{
    public static double CalculateAverage(int[] values)
    {
        return values.Average();
    }

    public static int CalculateMax(int[] values)
    {
        return values.Max();
    }
}
