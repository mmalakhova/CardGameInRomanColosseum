namespace CardGameInRomanColosseumDI;

public class MarkStrategy : IHostedService
{
    private readonly ILogger<MarkStrategy> _logger;

    public MarkStrategy(ILogger<MarkStrategy> logger)
    {
        _logger = logger;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("MarkStrategy service started");
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("MarkStrategy service stopped");
    }
}