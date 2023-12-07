using CardGameInRomanColiseum.Cards;

namespace CardGameInRomanColiseum;

public interface IStrategy
{
    public void PerformStrategy(Deck deck);
}