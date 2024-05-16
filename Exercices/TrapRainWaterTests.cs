namespace Exercices.UnitTests;

[TestClass]
public class TrapRainWaterTests
{
    [TestMethod]
    [DataRow(new int[] { })]
    [DataRow(new [] { 11 })]
    [DataRow(new [] { 11, 22 })]
    public void ReturnZeroWhenLessThanThreeValues(int[] values)
    {
        var trapRainWater = new TrapRainWater();

        var result = trapRainWater.Calculate(values);

        Assert.AreEqual(0, result);
    }

    [TestMethod]
    [DataRow(new [] { 1, 0, 0 })]
    [DataRow(new [] { 0, 0, 1 })]
    public void ReturnZeroWhenOneSizeIsOpen(int[] values)
    {
        var trapRainWater = new TrapRainWater();

        var result = trapRainWater.Calculate(values);

        Assert.AreEqual(0, result);
    }

    [TestMethod]
    [DataRow(new [] { 4, 0, 2 }, 2)]
    [DataRow(new [] { 3, 0, 5 }, 3)]
    public void ReturnLessLimitValue(int[] values, int expectedResult)
    {
        var trapRainWater = new TrapRainWater();

        var result = trapRainWater.Calculate(values);

        Assert.AreEqual(expectedResult, result);
    }
    
    [TestMethod]
    [DataRow(new [] { 0, 0, 1, 0, 0, 0, 1}, 3)]
    [DataRow(new [] { 1, 0, 0, 0, 1, 0, 0}, 3)]
    [DataRow(new [] { 0, 0, 1, 0, 0, 0, 1, 0, 0}, 3)]
    public void IgnorePadding(int[] values, int expectedResult)
    {
        var trapRainWater = new TrapRainWater();

        var result = trapRainWater.Calculate(values);

        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    [DataRow(new [] { 1, 0, 1 }, 1)]
    [DataRow(new [] { 1, 0, 0, 1 }, 2)]
    [DataRow(new [] { 1, 0, 0, 0, 1 }, 3)]
    public void CalculateSurfaceOnMultipleColumns(int[] values, int expectedResult)
    {
        var trapRainWater = new TrapRainWater();

        var result = trapRainWater.Calculate(values);

        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    [DataRow(new [] { 1, 0, 1, 0, 1 }, 2)]
    [DataRow(new [] { 3, 0, 5, 0, 3 }, 6)]
    [DataRow(new [] { 1, 0, 3, 0, 5, 0, 5, 0, 3, 0, 1 }, 13)]
    public void CalculateSurfaceOfMultipleBuckets(int[] values, int expectedResult)
    {
        var trapRainWater = new TrapRainWater();

        var result = trapRainWater.Calculate(values);

        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void ReturnZeroWhenNoWaterTrapped()
    {
        var values = new[] {1, 1, 1};

        var trapRainWater = new TrapRainWater();

        var result = trapRainWater.Calculate(values);

        Assert.AreEqual(0, result);
    }

    [TestMethod]
    [DataRow(new [] {3, 1, 0, 1, 2}, 4)]
    [DataRow(new [] {0, 1, 0, 2, 1, 0, 3, 1, 0, 1, 2}, 8)]
    public void CalculateMultipleLevelOfWater(int[] values, int expectedResult)
    {
        var trapRainWater = new TrapRainWater();

        var result = trapRainWater.Calculate(values);

        Assert.AreEqual(expectedResult, result);
    }
}