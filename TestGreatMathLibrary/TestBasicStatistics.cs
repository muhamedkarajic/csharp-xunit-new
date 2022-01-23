using Moq;

namespace MyFirstUnitTests;

public class TestBasicStatistics
{
    private class TestReader : IReaderBase
    {
        private readonly int[] numbers;

        public TestReader(int[] numbers) => this.numbers = numbers;

        public Task<IEnumerable<int>> ReadNumbersAsync()
            => Task.FromResult(numbers.AsEnumerable());
    }

    [Theory]
    [InlineData(6, 1, 2, 3)]
    [InlineData(12, 7, 2, 3)]
    [InlineData(18, 7, 8, 3)]
    public async Task SumValuesFromReaderWithTestClass(int expectedResult, params int[] numbers)
    {
        var reader = new TestReader(numbers);
        var statistics = new BasicStatistics(reader);
        var sum = await statistics.SumValuesFromReader();
        Assert.Equal(expectedResult, sum);
    }

    [Theory]
    [InlineData(6, 1, 2, 3)]
    [InlineData(12, 7, 2, 3)]
    [InlineData(18, 7, 8, 3)]
    public async Task SumValuesFromReaderWithMoq(int expectedResult, params int[] numbers)
    {
        var readerMock = new Mock<IReaderBase>();
        readerMock
            .Setup(x => x.ReadNumbersAsync())
            .Returns(Task.FromResult(numbers.AsEnumerable()));
        var statistics = new BasicStatistics(readerMock.Object);
        var sum = await statistics.SumValuesFromReader();
        Assert.Equal(expectedResult, sum);
    }
}
