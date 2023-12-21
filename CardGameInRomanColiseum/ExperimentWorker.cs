namespace CardGameInRomanColiseum;

public class ExperimentWorker
{
    private Player Mark { get; }
    private Player Elon { get; }
    private IDeckShuffler DeckShuffler { get; }
    private Statistics? Statistics { get; set; }

    public ExperimentWorker(Player mark, Player elon, IDeckShuffler deckShuffler)
    {
        Mark = mark;
        Elon = elon;
        DeckShuffler = deckShuffler;
    }
    
    public Statistics ConductExperiments(int experimentsNumber)
    {
        Statistics = new Statistics();
        for (var i = 0; i < experimentsNumber; ++i)
        {
            ConductExperiment();
        }
        Statistics.Calculate();
        return Statistics;
    }

    private void ConductExperiment()
    {
        var deck = new Deck();
        DeckShuffler.ShuffleDeck(deck);
        var decks = deck.Split();
        var marksDeck = decks[0];
        var elonsDeck = decks[1];

        var marksCard = Mark.PickCard(marksDeck);
        var elonsCard = Elon.PickCard(elonsDeck);
        
        var success = elonsCard.CompareCards(marksCard);
        if (success)
        {
            Statistics!.registerSuccess();
        }
        else
        {
            Statistics!.registerFailure();
        }
    }
}