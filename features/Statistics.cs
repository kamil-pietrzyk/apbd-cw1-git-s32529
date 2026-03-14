namespace apbd_cw1_git_s32529.features;

public static class Statistics
{
    public static double CalculateAverage(int[] values)
    {
        if (values == null || values.Length == 0) return 0;
        double sum = 0;
        foreach (int val in values) sum += val;
        return sum / values.Length;
    }
    
    public static int CalculateMax(int[] values)
    {
        if (values == null || values.Length == 0) throw new ArgumentException("Lack of data");
        int max = values[0];
        foreach (int val in values) { if (val > max) max = val; }
        return max;
    }
    
    public static int CalculateMin(int[] values)
    {
        if (values == null || values.Length == 0) throw new ArgumentException("Brak danych");
        int min = values[0];
        foreach (int val in values) { if (val < min) min = val; }
        return min;
    }
}