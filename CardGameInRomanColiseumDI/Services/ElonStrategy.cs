using CardGameInRomanColiseum.Cards;

namespace CardGameInRomanColosseumDI;

public class ElonStrategy : IHostedService, IStrategy
{
    private const int ElonsCardNumber = 1;
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

    public Card PickTheCard(Deck deck)
    {
        return deck.GetCardByNumber(ElonsCardNumber - 1);
    }
}