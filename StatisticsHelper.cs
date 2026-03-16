using System.Linq;

public class StatisticsHelper
{
    public static double CalculateAverage(int[] values)
    {
        return values.Average();
    }
    // Returns the minimum value in the array
    public static int CalculateMin(int[] values)
    {
    return values.Min();
    }

    public static int CalculateMax(int[] values)
    {
        return values.Max();
    }
}
