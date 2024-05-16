namespace Exercices.Challenge02;

[TestClass]
public class ContainerWithMostWaterTests
{
    [TestMethod]
    public void WhenThereIsNoValuesReturnZero()
    {
        var calculator = new ContainerWithMostWater();
        var values = new int[] { };

        var result = calculator.Calculate(values);

        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void CalculateHorizontalArea()
    {
        var calculator = new ContainerWithMostWater();
        var values = new[] { 1, 1, 1, 1, 3, 1, 3, 1, 1, 1, 1 };
        var area = calculator.Calculate(values);

        Assert.AreEqual(11, area);
    }

    [TestMethod]
    public void CalculateVerticalArea()
    {
        var calculator = new ContainerWithMostWater();
        var values = new[] { 1, 3, 1, 3, 1 };
        var area = calculator.Calculate(values);

        Assert.AreEqual(9, area);
    }


    [TestMethod]
    [DataRow(new[] { 7, 1, 2, 3, 9 }, 35)]
    [DataRow(new[] { 6, 9, 3, 4, 5, 8 }, 40)]
    public void CalculateRandomArea(int[] values, int expectedArea)
    {
        var calculator = new ContainerWithMostWater();
        var area = calculator.Calculate(values);

        Assert.AreEqual(expectedArea, area);
    }

}
