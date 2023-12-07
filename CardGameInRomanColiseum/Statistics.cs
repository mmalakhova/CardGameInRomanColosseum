namespace CardGameInRomanColiseum;

public class Statistics
{
    public decimal _ratio { get; set; }

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