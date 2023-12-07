using CardGameInRomanColiseum.Exceptions;

namespace CardGameInRomanColiseum.Cards;

public class Deck
{
    public List<Card> Cards { get; set; }

    public Deck()
    {
        Cards = new List<Card>();
        for (var i = 0; i < 18; i++)
        {
            Cards.Add(new Card(Card.CardColor.Black));
            Cards.Add(new Card(Card.CardColor.Red));
        }
    }

    public Deck(List<Card> cards)
    {
        Cards = cards;
    }

    public Card GetCardByNumber(int cardNumber)
    {
        if (cardNumber > Cards.Count)
            throw new DeckCapacityException("Invalid card number passed, deck capacity is " + Cards.Count);
        return Cards[cardNumber];
    }
}