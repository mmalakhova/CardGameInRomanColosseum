namespace CardGameInRomanColiseum;

public class Statistics
{
    private decimal _ratio;

    public void CalculateStatistics(ExperimentResult experimentResult)
    {
        if (experimentResult.NumberOfDefeats == 0) experimentResult.NumberOfDefeats = 1;
        _ratio = Math.Round((decimal)experimentResult.NumberOfVictories / experimentResult.NumberOfDefeats * 100, 1,
            MidpointRounding.ToEven);
    }

    public void DisplayStatistics()
    {
        Console.WriteLine($"Number of successes to total number of experiments: {_ratio}%");
    }
}