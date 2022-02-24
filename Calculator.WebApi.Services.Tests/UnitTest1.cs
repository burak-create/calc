using NUnit.Framework;
namespace Calculator.WebApi.Services.Tests;

public class Tests
{
    private ICalculator actor;
    

    [SetUp]
    public void Setup()
    {
        actor = new SimpleCalcService();
    }

    [Test]
    public void SUM_OF_POSITIVE_NUMBERS()
    {
        const double n1 = 10;
        const double n2 = 15;
        const double expected = 25;

        var result = actor.Add(n1, n2);
        result.Equals(expected);
    }

    [Test]
    public void SUM_OF_NEGATIVE_NUMBERS()
    {
        const double n1 = -5;
        const double n2 = -10;
        const double expected = -15;

        var result = actor.Add(n1, n2);
        result.Equals(expected);
    }

    [Test]
    public void SUM_OF_NEGATIVE_AND_POSITIVE_NUMBERS()
    {
        const double n1 = -3;
        const double n2 = 3;
        const double expected = 0;
        var result = actor.Add(n1, n2);
        result.Equals(expected);
        
    }
}