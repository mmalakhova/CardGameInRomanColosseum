using CardGameInRomanColiseum;

namespace CardGameInRomanColosseumDI;

public class Statistics : IHostedService
{
    private readonly ILogger<Statistics> _logger;
    private decimal _ratio;

    public Statistics(ILogger<Statistics> logger)
    {
        _logger = logger;
    }

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

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Statistics service started");
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Statistics service stopped");
    }
}