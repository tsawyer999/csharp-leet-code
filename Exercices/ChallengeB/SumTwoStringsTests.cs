namespace Exercices.ChallengeB;

[TestClass]
public class SumTwoStringsTests
{
    [TestMethod]
    [DataRow("a", "10")]
    [DataRow("-", "20")]
    [DataRow(".", "30")]
    [DataRow("40", "+")]
    [DataRow("50", "@")]
    public void WhenValueIsNotNumericThenReturnMinusOne(string a, string b)
    {
        var sum = SumTwoStrings.SumStrings(a, b);

        Assert.AreEqual("-1", sum);
    }

    [TestMethod]
    [DataRow("", "1", "1")]
    [DataRow("2", "", "2")]
    [DataRow("", "", "0")]
    public void WhenValueIsEmptyConsiderZero(string a, string b, string expectedResult)
    {
        var sum = SumTwoStrings.SumStrings(a, b);

        Assert.AreEqual(expectedResult, sum);
    }

    [TestMethod]
    public void SumTwoNumbersWithSameLength()
    {
        var sum = SumTwoStrings.SumStrings("1", "2");

        Assert.AreEqual("3", sum);
    }

    [TestMethod]
    public void SumTwoNumbersWithPaddedZero()
    {
        var sum = SumTwoStrings.SumStrings("0001", "0002");

        Assert.AreEqual("3", sum);
    }

    [TestMethod]
    public void SumTwoNumbersWithARetainer()
    {
        var sum = SumTwoStrings.SumStrings("7", "5");

        Assert.AreEqual("12", sum);
    }

    [TestMethod]
    [DataRow("2", "14", "16")]
    [DataRow("99", "2", "101")]
    [DataRow("10000", "5", "10005")]
    public void SumTwoNumbersWithVariousLength(string a, string b, string expectedResult)
    {
        var sum = SumTwoStrings.SumStrings(a, b);

        Assert.AreEqual(expectedResult, sum);
    }

    [TestMethod]
    public void SumTwoLargeNumbers()
    {
        var sum = SumTwoStrings.SumStrings("712569312664357328695151392", "8100824045303269669937");

        Assert.AreEqual("712577413488402631964821329", sum);
    }
}