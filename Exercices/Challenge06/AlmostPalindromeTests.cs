using FluentAssertions;

namespace Exercices.Challenge06;

[TestClass]
public class AlmostPalindromeTests
{
    [TestMethod]
    [DataRow("ZZZabacZZZ")]
    [DataRow("ZZZcabaZZZ")]
    [DataRow("ZZZcabbaZZZ")]
    public void ReturnTrueWhenAlmostPalindrome(string value)
    {
        var processor = new AlmostPalindrome();

        var result = processor.IsAlmostPalindrome(value);

        result.Should().BeTrue();
    }

    [TestMethod]
    [DataRow("ababb")]
    public void ReturnFalseWhenAlmostPalindrome(string value)
    {
        var processor = new AlmostPalindrome();

        var result = processor.IsAlmostPalindrome(value);

        result.Should().BeFalse();
    }
}
