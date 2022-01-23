namespace GreatMathLibrary;

public class BasicStatistics
{
    private readonly IReaderBase reader;

    public BasicStatistics(IReaderBase reader)
    {
        this.reader = reader;
    }

    public async Task<int> SumValuesFromReader()
    {
        var numbers = await reader.ReadNumbersAsync();
        return numbers.Sum();
    }
}
