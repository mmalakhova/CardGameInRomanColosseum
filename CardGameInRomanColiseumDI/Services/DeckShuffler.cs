using CardGameInRomanColiseum.Cards;

namespace CardGameInRomanColosseumDI;

public class DeckShuffler : IHostedService
{
    private readonly ILogger<DeckShuffler> _logger;
    private Deck _deck;

    public DeckShuffler(ILogger<DeckShuffler> logger)
    {
        _logger = logger;
        _deck = new Deck();
    }

    public Deck ShuffleCards()
    {
        var shuffledCards = _deck.Cards.OrderBy(_ => new Random().Next());
        _deck.Cards = shuffledCards.ToList();
        return _deck;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("DeckShuffler service started");
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("DeckShuffler service stopped");
    }
}