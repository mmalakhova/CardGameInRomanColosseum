using CardGameInRomanColiseum;

namespace CardGameInRomanColosseumDI;
public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    private static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureServices((_, services) =>
            {
                services.AddHostedService<ColiseumExperimentWorker>();
                services.AddScoped<DeckShufflerImpl>();
                services.AddScoped<SimpleCardPickStrategy>();
            });
    }
}