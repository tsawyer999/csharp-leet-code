namespace Exercices.Challenge06;

[TestClass]
public class PalindromeTests
{
    [TestMethod]
    [DataRow("")]
    [DataRow("a")]
    [DataRow("aba")]
    [DataRow("abba")]
    public void ReturnTrueWhenIsPalindrome(string value)
    {
        var processor = new Palindrome();

        var result = processor.IsPalindrome(value);

        Assert.IsTrue(result);
    }

    [TestMethod]
    [DataRow("abc")]
    public void ReturnFalseWhenIsNotAPalindrome(string value)
    {
        var processor = new Palindrome();

        var result = processor.IsPalindrome(value);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void ShouldIgnoreSyntax()
    {
        var processor = new Palindrome();

        var result = processor.IsPalindrome("a man, a plan, a canal: panama");

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void ShouldIgnoreCase()
    {
        var processor = new Palindrome();

        var result = processor.IsPalindrome("aBbA");

        Assert.IsTrue(result);
    }
}
