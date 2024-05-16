using FluentAssertions;

namespace Exercices.Challenge04;

[TestClass]
public class LonguestSubstringTests
{
    [TestMethod]
    [DataRow(null)]
    [DataRow("")]
    public void Return0WhenStringIsNullOrEmpty(string value)
    {
        var processor = new LonguestSubstring();

        var result = processor.Process(value);

        result.Should().Be(0);
    }

    [TestMethod]
    [DataRow("abc", 3)]
    [DataRow("abcc", 3)]
    [DataRow("abccmnopqr", 6)]
    [DataRow("abccmnopppqraabcdefghijaaaaaab", 10)]
    public void ReturnSubstringLength(string value, int expectedLength)
    {
        var processor = new LonguestSubstring();

        var result = processor.Process(value);

        result.Should().Be(expectedLength);
    }
}
