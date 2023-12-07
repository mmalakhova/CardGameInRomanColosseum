namespace CardGameInRomanColosseumDI;

public class ElonStrategy : IHostedService
{
    private readonly ILogger<ElonStrategy> _logger;

    public ElonStrategy(ILogger<ElonStrategy> logger)
    {
        _logger = logger;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("ElonStrategy service started");
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("ElonStrategy service stopped");
    }
}