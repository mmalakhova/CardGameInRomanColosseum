namespace CardGameInRomanColosseumDI;

public class Experiment : IHostedService
{
    private readonly ILogger<Experiment> _logger;

    public Experiment(ILogger<Experiment> logger)
    {
        _logger = logger;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Experiment service started");
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Experiment service stopped");
    }
}