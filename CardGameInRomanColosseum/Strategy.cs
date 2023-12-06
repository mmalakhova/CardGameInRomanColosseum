using CardGameInRomanColosseum.Cards;

namespace CardGameInRomanColosseum;

public class Strategy
{
    private const int PlayerDeckSize = 18;
    private const int OtherPlayerCardNumber = 1;
    private int _numberOfVictories;
    private int _numberOfDefeats;

    public void PerformFirstCardStrategy(Deck deck)
    {
        var splitDecks = deck.Cards.Chunk(PlayerDeckSize).ToList();
        var elonsDeck = new Deck(splitDecks.ElementAt(0).ToList());
        var marksDeck = new Deck(splitDecks.ElementAt(1).ToList());

        var elonCard = elonsDeck.GetCardByNumber(OtherPlayerCardNumber - 1);
        var markCard = marksDeck.GetCardByNumber(OtherPlayerCardNumber - 1);
        var isWinCondition = elonCard.CompareCards(markCard);
        if (isWinCondition)
        {
            ++_numberOfVictories;
            return;
        }
        ++_numberOfDefeats;
    }

    public void CalculateStatistics()
    {
        if (_numberOfDefeats == 0) _numberOfDefeats = 1;
        var ratio = Math.Round((decimal)_numberOfVictories / _numberOfDefeats * 100, 1, MidpointRounding.ToEven);
        Console.WriteLine("Number of successes to total number of experiments: " + ratio + "%");
    }
}