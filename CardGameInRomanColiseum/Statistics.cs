namespace CardGameInRomanColiseum;

public class Statistics
{
    public double? Ratio { get; set; }
    public int OverallExperimentsNumber { get; set; }
    public int SuccessfulExperimentsNumber { get; set; }

    public void registerSuccess()
    {
        ++OverallExperimentsNumber;
        ++SuccessfulExperimentsNumber;
    }

    public void registerFailure()
    {
        ++OverallExperimentsNumber;
    }
    
    public void Calculate()
    {
        Ratio = (double) SuccessfulExperimentsNumber / OverallExperimentsNumber * 100;
    }
}