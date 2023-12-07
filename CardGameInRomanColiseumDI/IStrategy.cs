using CardGameInRomanColiseum.Cards;

namespace CardGameInRomanColosseumDI;

public interface IStrategy
{
    public Card PickTheCard(Deck deck);
}