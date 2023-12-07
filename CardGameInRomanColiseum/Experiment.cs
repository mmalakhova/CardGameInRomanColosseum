using CardGameInRomanColiseum.Cards;

namespace CardGameInRomanColiseum;

static class Experiment
{
    static void Main()
    {
        var deck = new Deck();
        var shuffler = new Shuffler();
        var strategy = new FirstCardStrategy();
        var statistics = new Statistics();
        for (var i = 0; i < 1000000; i++)
        {
            deck = shuffler.ShuffleCards(deck);
            strategy.PerformStrategy(deck);
        }
        statistics.CalculateStatistics(strategy.PassTheResult());
        statistics.DisplayStatistics();
    }
}