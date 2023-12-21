using CardGameInRomanColiseum.Strategy;

namespace CardGameInRomanColiseum;

public class SimpleCardPickStrategy : ICardPickStrategy
{
    public Card PickCard(Deck deck)
    {
        return deck.Cards[0];
    }
}