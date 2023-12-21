namespace CardGameInRomanColiseum;

public class ConsoleStatisticsPrinter: IStatisticsPrinter
{
    public void PrintStatistics(Statistics statistics)
    {
        Console.WriteLine($"Number of successes to total number of experiments: {statistics.Ratio}%");
    }
}