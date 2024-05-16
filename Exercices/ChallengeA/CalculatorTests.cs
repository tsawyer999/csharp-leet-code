namespace Exercices.ChallengeA;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    [DataRow("")]
    [DataRow(" ")]
    [DataRow(null)]
    public void Return0WhenInputIsEmpty(string values)
    {
        var result = Calculator.Add(values);

        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void ReturnNumberWhenInputIsOnlyOneNumber()
    {
        var result = Calculator.Add("1");

        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void ReturnSumWhenInputUseDefaultSeperator()
    {
        var result = Calculator.Add("12,2");

        Assert.AreEqual(14, result);
    }

    [TestMethod]
    [DataRow("//;#1;2", 3)]
    [DataRow("//;#11;5", 16)]
    public void ReturnSumWhenInputUseCustomSeperator(string values, int expectedResult)
    {
        var result = Calculator.Add(values);

        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    [DataRow("//;#16;-51;-2", "Negatives not allowed -51,-2")]
    [DataRow("//---#11---20---3----3", "Negatives not allowed -3")]
    public void RaiseExceptionWhenOneOrMultipleNegativeNumberFound(string values, string expectedMessage)
    {
        var exception = Assert.ThrowsException<Exception>(() => Calculator.Add(values));

        Assert.AreEqual(expectedMessage, exception.Message);
    }

    [TestMethod]
    [DataRow("23, 1001", 23)]
    [DataRow("//;#23;1001;11", 34)]
    public void IgnoreNumberThatAreExceeding1000(string values, int expectedResult)
    {
        var result = Calculator.Add(values);

        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    [DataRow("//banana#1banana3banana2", 6)]
    [DataRow("//***#11***20***3", 34)]
    [DataRow("//---#11---20---4", 35)]
    public void ReturnSumWhenInputUseCustomSeperatorWithVariousLength(string values, int expectedResult)
    {
        var result = Calculator.Add(values);

        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void ReturnSumWhenInputUseMultipleCustomSeperator()
    {
        var result = Calculator.Add("//[*][%]#11*2%17");

        Assert.AreEqual(30, result);
    }

    [TestMethod]
    public void ReturnSumWhenInputUseMultipleCustomSeperatorWithVariousLength()
    {
        var result = Calculator.Add("//[abc][%%]#11abc2%%17");

        Assert.AreEqual(30, result);
    }
}