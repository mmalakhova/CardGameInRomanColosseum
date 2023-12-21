using CardGameInRomanColiseum;
using CardGameInRomanColiseum.Strategy;

namespace CardGameInRomanColosseumDI;

public class SimpleCardPickStrategy : IHostedService, ICardPickStrategy
{
    private readonly ILogger<SimpleCardPickStrategy> _logger;

    public SimpleCardPickStrategy(ILogger<SimpleCardPickStrategy> logger)
    {
        _logger = logger;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("SimpleCardPickStrategy service started");
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("SimpleCardPickStrategy service stopped");
    }

    public Card PickCard(Deck deck)
    {
        return deck.Cards[0];
    }
}