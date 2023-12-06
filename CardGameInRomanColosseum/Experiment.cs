using CardGameInRomanColosseum.Cards;

namespace CardGameInRomanColosseum;

class Experiment
{
    static void Main()
    {
        var deck = new Deck();
        deck.CreateDeck();
        var shuffler = new Shuffler();
        deck = shuffler.ShuffleCards(deck);
        
    }
}