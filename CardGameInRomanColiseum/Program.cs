namespace CardGameInRomanColiseum;

static class Program
{
    private const int ExperimentsNumber = 1_000_000;

    static void Main()
    {
        var shuffler = new DeckShufflerImpl();
        var simpleStrategy = new SimpleCardPickStrategy();
        var mark = new Player(simpleStrategy);
        var elon = new Player(simpleStrategy);
        var consoleStatisticsPrinter = new ConsoleStatisticsPrinter();
        
        var experimentWorker = new ExperimentWorker(mark, elon, shuffler);
        var statistics = experimentWorker.ConductExperiments(ExperimentsNumber);
        
        consoleStatisticsPrinter.PrintStatistics(statistics);
    }
}