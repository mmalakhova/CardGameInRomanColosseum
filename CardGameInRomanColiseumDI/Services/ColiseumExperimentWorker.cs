using CardGameInRomanColiseum;
using CardGameInRomanColiseum.Cards;

namespace CardGameInRomanColosseumDI;

public class ColiseumExperimentWorker : BackgroundService
{
    private readonly ILogger<ColiseumExperimentWorker> _logger;
    private DeckShuffler _shuffler;
    private MarkStrategy _markStrategy;
    private ElonStrategy _elonStrategy;
    private Experiment _experiment;
    private Statistics _statistics;
    private IServiceProvider ServiceProvider { get; }


    public ColiseumExperimentWorker(ILogger<ColiseumExperimentWorker> logger, IServiceProvider serviceProvider)
    {
        _logger = logger;
        ServiceProvider = serviceProvider;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("ColiseumExperimentWorker service is running");
        using (var scope = ServiceProvider.CreateScope())
        {
            _shuffler = scope.ServiceProvider.GetRequiredService<DeckShuffler>();
            _elonStrategy = scope.ServiceProvider.GetRequiredService<ElonStrategy>();
            _markStrategy = scope.ServiceProvider.GetRequiredService<MarkStrategy>();
            _experiment = scope.ServiceProvider.GetRequiredService<Experiment>();
            _statistics = scope.ServiceProvider.GetRequiredService<Statistics>();
        }

        Work();
        _statistics.CalculateStatistics(_experiment.PassTheResult());
        _statistics.DisplayStatistics();
        Environment.Exit(0);
    }

    private void Work()
    {
        for (var i = 0; i < 1000000; i++)
        {
            Deck deck = _shuffler.ShuffleCards();
            _experiment.ConductExperiment(_elonStrategy, _markStrategy, deck);
        }
    }
}