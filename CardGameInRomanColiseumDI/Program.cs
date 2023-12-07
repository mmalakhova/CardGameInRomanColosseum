namespace CardGameInRomanColosseumDI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                {
                    services.AddHostedService<ColiseumExperimentWorker>();
                    services.AddScoped<DeckShuffler>();
                    services.AddScoped<ElonStrategy>();
                    services.AddScoped<MarkStrategy>(); 
                    services.AddScoped<Experiment>();
                });
        }
    }
}