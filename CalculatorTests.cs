using FluentAssertions;

namespace Support_TestProject;

public class CalculatorTests
{
    [Test]
    public void Sum()
    {
        var testee = new Calculator();

        var result = Calculator.Sum(1,2);

        result.Should().Be(3);
    }
}