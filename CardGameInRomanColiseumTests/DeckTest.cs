using CardGameInRomanColiseum;
using CardGameInRomanColiseum.Cards;

namespace CardGameInRomanColiseumTests;

public class CardGameTests
{
    [SetUp]
    public void Setup()
    {
    }

    /// <summary>
    /// Тест колоды карт.
    /// Проверить, что колода карт должна иметь по 18 черных и 18 красных карт
    /// </summary>
    [Test]
    public void CreateCardDeck_ShouldContain18RedsAnd18Blacks()
    {
        var deck = new Deck();
        var redsCount = 0;
        var blackCount = 0;
        foreach (var card in deck.Cards)
        {
            switch (card._color)
            {
                case Card.CardColor.Black:
                    ++blackCount;
                    break;
                case Card.CardColor.Red:
                    ++redsCount;
                    break;
            }
        }
        
        Assert.That(redsCount == 18);
        Assert.That(blackCount == 18);
    }
    
    /// <summary>
    /// Тест на стратегию.
    /// Проверить, что стратегия должна давать определённый результат на определенным образом перемешанную половину колоды
    /// </summary>
    [Test]
    public void PerformStrategy_WithOrderedHalfBlacksAndHalfReds_ShouldReturn50Percent()
    {
        var cards = new List<Card>();
        for (var i = 0; i < 18; i++)
        {
            cards.Add(new Card(Card.CardColor.Black));
        }
        for (var i = 0; i < 18; i++)
        {
            cards.Add(new Card(Card.CardColor.Red));
        }

        var deck = new Deck(cards);
        var statistics = new Statistics();
        var strategy = new FirstCardStrategy();
        strategy.PerformStrategy(deck);
        statistics.CalculateStatistics(strategy.PassTheResult());
        
        Console.WriteLine(statistics._ratio);
        Assert.That(statistics._ratio == 0);
    }
    
    /// <summary>
    /// Тест на проведение эксперимента.
    /// Колода должна быть перемешана.
    /// </summary>
    [Test]
    public void ConductExperiment_DeckShouldBeShuffled()
    {
        var deck = new Deck();
        var shuffler = new Shuffler();
        var strategy = new FirstCardStrategy();
        var statistics = new Statistics();
        for (var i = 0; i < 1000000; i++)
        {
            deck = shuffler.ShuffleCards(deck);
            strategy.PerformStrategy(deck);
        }
        statistics.CalculateStatistics(strategy.PassTheResult());

        var notShuffledDeck = new Deck();
        var numberOfMatches = deck.Cards.Where((t, i) => notShuffledDeck.Cards[i].CompareCards(t)).Count();
        
        Assert.That(numberOfMatches < 36);
    }
    
    /// <summary>
    /// Тест на проведение эксперимента.
    /// Корректность результата эксперимента.
    /// </summary>
    [Test]
    public void ConductExperiment_ZeroWinningCondition_ResultShouldBeZero()
    {
        var cards = new List<Card>();
        for (var i = 0; i < 18; i++)
        {
            cards.Add(new Card(Card.CardColor.Black));
        }
        for (var i = 0; i < 18; i++)
        {
            cards.Add(new Card(Card.CardColor.Red));
        }

        var deck = new Deck(cards);
        var strategy = new FirstCardStrategy();
        var statistics = new Statistics();
        for (var i = 0; i < 1000000; i++)
        {
            strategy.PerformStrategy(deck);
        }
        statistics.CalculateStatistics(strategy.PassTheResult());
        
        Assert.That(statistics._ratio == 0);
    }
}