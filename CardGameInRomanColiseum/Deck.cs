namespace CardGameInRomanColiseum;

public class Deck
{
    private const int DefaultSize = 36;

    public List<Card> Cards { get; set; }

    public Deck()
    {
        Cards = new List<Card>();
        for (var i = 0; i < DefaultSize / 2; i++)
        {
            Cards.Add(new Card(Card.CardColor.Black));
            Cards.Add(new Card(Card.CardColor.Red));
        }
    }

    public Deck(List<Card> cards)
    {
        Cards = cards.ToList();
    }

    public Deck[] Split()
    {
        Deck[] decks = new Deck[2];
        var splitted = Cards.Chunk(DefaultSize / 2).ToList();
        decks[0] = new Deck(splitted[0].ToList());
        decks[1] = new Deck(splitted[1].ToList());
        return decks;
    }
}