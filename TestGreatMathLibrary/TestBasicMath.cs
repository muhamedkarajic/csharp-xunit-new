namespace MyFirstUnitTests;

public class TestBasicMath
{
    [Fact]
    public void AddFact()
    {
        var result = BasicMath.Add(1, 1);
        Assert.Equal(2, result);
    }

    [Theory]
    [InlineData(1,2,3)]
    [InlineData(2,3,5)]
    [InlineData(3,3,6)]
    [InlineData(3,6,9)]
    public void AddTheory(int a, int b, int expectedResult)
    {
        var result = BasicMath.Add(a, b);
        Assert.Equal(expectedResult, result);
    }
}
