using CardGameInRomanColiseum.Strategy;

namespace CardGameInRomanColiseum;

public class Player
{
    private ICardPickStrategy CardPickStrategy { get; }

    public Player(ICardPickStrategy cardPickStrategy)
    {
        CardPickStrategy = cardPickStrategy;
    }

    public Card PickCard(Deck deck)
    {
        return CardPickStrategy.PickCard(deck);
    }
}