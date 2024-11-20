namespace Leonardo.Tests;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        var results = await Fibonacci.RunAsync(["42"]);
        Assert.Equal(42, results[0].Input);
        Assert.Equal(267914296, results[0].Result);
    }
}