using FluentAssertions;

namespace Exercices.Challenge04;

[TestClass]
public class TypedOutTests
{
    [TestMethod]
    [DataRow("ab#z", "az#z")]
    [DataRow("x#y#z#", "a#")]
    [DataRow("a###b", "b")]
    public void ReturnTrue(string value1, string value2)
    {
        var processor = new TypedOut();

        var result = processor.Process(value1, value2);

        result.Should().BeTrue();
    }

    [TestMethod]
    [DataRow("abc#d", "acc#c")]
    [DataRow("ab#z ", "az#z")]
    public void ReturnFalse(string value1, string value2)
    {
        var processor = new TypedOut();

        var result = processor.Process(value1, value2);

        result.Should().BeFalse();
    }
}
