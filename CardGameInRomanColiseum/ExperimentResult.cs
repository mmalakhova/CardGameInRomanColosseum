namespace CardGameInRomanColiseum;

public class ExperimentResult
{
    public ExperimentResult(int numberOfVictories, int numberOfDefeats)
    {
        NumberOfVictories = numberOfVictories;
        NumberOfDefeats = numberOfDefeats;
    }

    public int NumberOfVictories { get; }
    public int NumberOfDefeats { get; set; }
}