namespace MyFirstUnitTests;

public class TestNumbersReader
{
    [Fact]
    public async Task ResultOfNumbersReader()
    {
        var reader = new NumbersReader();
        var result = await reader.ReadNumbersAsync();
        Assert.Equal(new[] { 1, 2, 3, 4, 5 }, result);
    }
}
