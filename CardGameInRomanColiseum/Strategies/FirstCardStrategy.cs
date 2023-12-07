using CardGameInRomanColiseum.Cards;

namespace CardGameInRomanColiseum;

public class FirstCardStrategy : IStrategy
{
    private const int PlayerDeckSize = 18;
    private const int OtherPlayerCardNumber = 1;
    private int _numberOfVictories;
    private int _numberOfDefeats;

    public void PerformStrategy(Deck deck)
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

    public ExperimentResult PassTheResult()
    {
        return new ExperimentResult(_numberOfVictories, _numberOfDefeats);
    }
}