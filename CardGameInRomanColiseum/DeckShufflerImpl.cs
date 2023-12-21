namespace CardGameInRomanColiseum;

public class DeckShufflerImpl : IDeckShuffler
{
    public void ShuffleDeck(Deck deck)
    {
        var random = new Random();
        deck.Cards = deck.Cards.OrderBy(_ => random.Next()).ToList();
    }
}