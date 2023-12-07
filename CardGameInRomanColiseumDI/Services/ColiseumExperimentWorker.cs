namespace CardGameInRomanColosseumDI;

public class ColiseumExperimentWorker : BackgroundService
{
    private readonly ILogger<ColiseumExperimentWorker> _logger;
    private DeckShuffler _shuffler;
    private MarkStrategy _markStrategy;
    private ElonStrategy _elonStrategy;
    private Experiment _experiment;
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

        }
        Environment.Exit(0);
    }
}