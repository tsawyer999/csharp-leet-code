namespace Exercices.ChallengeC;

[TestClass]
public class BooleanOrderTests
{
    [TestMethod]
    [DataRow("tt", 1)]
    [DataRow("tf", 0)]
    [DataRow("ft", 0)]
    [DataRow("ff", 0)]
    public void AndOperator(string operands, int expected)
    {
        var processor = new BooleanOrder(operands, "&");
        var result = processor.Solve();
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow("tt", 1)]
    [DataRow("tf", 1)]
    [DataRow("ft", 1)]
    [DataRow("ff", 0)]
    public void OrOperator(string operands, int expected)
    {
        var processor = new BooleanOrder(operands, "|");
        var result = processor.Solve();
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow("tt", 0)]
    [DataRow("tf", 1)]
    [DataRow("ft", 1)]
    [DataRow("ff", 0)]
    public void XorOperator(string operands, int expected)
    {
        var processor = new BooleanOrder(operands, "^");
        var result = processor.Solve();
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow("ttt", "||", 2)]
    [Ignore]
    public void MultipleOperators(string operands, string operators, int expected)
    {
        var processor = new BooleanOrder(operands, operators);
        var result = processor.Solve();
        Assert.AreEqual(expected, result);
    }

    //[TestMethod]
    //[Ignore]
    //public void Test1()
    //{
    //    Assert.AreEqual(new BigInteger(2), new BooleanOrder("tft", "^&").Solve());
    //}

    //[TestMethod]
    //[Ignore]
    //public void Test2()
    //{

    //    Assert.AreEqual(new BigInteger(16), new BooleanOrder("ttftff", "|&^&&").Solve());
    //}

    //[TestMethod]
    //[Ignore]
    //public void Test3()
    //{

    //    Assert.AreEqual(new BigInteger(339), new BooleanOrder("ttftfftf", "|&^&&||").Solve());
    //}

    //[TestMethod]
    //[Ignore]
    //public void Test4()
    //{

    //    Assert.AreEqual(new BigInteger(851), new BooleanOrder("ttftfftft", "|&^&&||^").Solve());
    //}

    //[TestMethod]
    //[Ignore]
    //public void Test5()
    //{

    //    Assert.AreEqual(new BigInteger(2434), new BooleanOrder("ttftfftftf", "|&^&&||^&").Solve());
    //}

    //[TestMethod]
    //[Ignore]
    //public void Test6()
    //{
    //    Assert.AreEqual(new BigInteger(945766470799), new BooleanOrder("ttftfftftffttfftftftfftft", "|&^&&||^&&^^|&&||^&&||&^").Solve());
    //}
}