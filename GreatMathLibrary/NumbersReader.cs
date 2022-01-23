namespace GreatMathLibrary;

//public abstract class ReaderBase
//{
//    public abstract Task<IEnumerable<int>> ReadNumbersAsync();
//}

public interface IReaderBase
{
    Task<IEnumerable<int>> ReadNumbersAsync();
}

internal class NumbersReader : IReaderBase
{
    public async Task<IEnumerable<int>> ReadNumbersAsync()
    {
        var fileContent = await File.ReadAllTextAsync("numbers.txt");
        
        return fileContent
            .Split(',')
            .Select(valueText => int.Parse(valueText));
    }
}
