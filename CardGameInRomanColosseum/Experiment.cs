using CardGameInRomanColosseum.Cards;

namespace CardGameInRomanColosseum;

static class Experiment
{
    static void Main()
    {
        var deck = new Deck();
        deck.CreateDeck();
        var shuffler = new Shuffler();
        var strategy = new Strategy();
        for (var i = 0; i < 1000000; i++)
        {
            deck = shuffler.ShuffleCards(deck);
            strategy.PerformFirstCardStrategy(deck);
        }
        strategy.CalculateStatistics();
    }
}