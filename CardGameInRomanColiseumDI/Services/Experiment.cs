using CardGameInRomanColiseum;
using CardGameInRomanColiseum.Cards;

namespace CardGameInRomanColosseumDI;

public class Experiment : IHostedService
{
    private const int PlayerDeckSize = 18;
    private int _numberOfVictories;
    private int _numberOfDefeats;
    private readonly ILogger<Experiment> _logger;

    public Experiment(ILogger<Experiment> logger)
    {
        _logger = logger;
    }

    public void ConductExperiment(IStrategy firstPlayerStrategy, IStrategy secondPlayerStrategy, Deck deck)
    {
        var splitDecks = deck.Cards.Chunk(PlayerDeckSize).ToList();
        var firstPlayerDeck = new Deck(splitDecks.ElementAt(0).ToList());
        var secondPlayerDeck = new Deck(splitDecks.ElementAt(1).ToList());

        var firstPlayerCard = firstPlayerStrategy.PickTheCard(secondPlayerDeck);
        var secondPlayerCard = secondPlayerStrategy.PickTheCard(firstPlayerDeck);

        var isWinCondition = firstPlayerCard.CompareCards(secondPlayerCard);
        if (isWinCondition)
        {
            ++_numberOfVictories;
            return;
        }

        ++_numberOfDefeats;
    }

    public ExperimentResult PassTheResult()
    {
        return new ExperimentResult(_numberOfVictories, _numberOfDefeats);
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