namespace Exercices.Challenge07;

[TestClass]
public class SubLinkedListReversalTests
{
    [TestMethod]
    [DataRow(3, 5, "1254367")]
    [DataRow(1, 2, "2134567")]
    [DataRow(6, 7, "1234576")]
    public void ReverseSubListBetweenIndexes(int leftIndex, int rightIndex, string expectedResult)
    {
        var firstNode = new Node(1);
        var node = firstNode;
        for (var i = 2; i <= 7; i++)
        {
            node.NextNode = new Node(i);
            node = node.NextNode;
        }

        var processor = new SubLinkedListReversal();

        var result = processor.SubReverseList(firstNode, leftIndex, rightIndex);

        Assert.AreEqual(expectedResult, result.ToString());
    }

    [TestMethod]
    [Description("1234567 -> 1234567")]
    public void ReturnSameStringWhenLeftIndexNotReached()
    {
        var firstNode = new Node(1);
        var node = firstNode;
        for (var i = 2; i <= 7; i++)
        {
            node.NextNode = new Node(i);
            node = node.NextNode;
        }

        var processor = new SubLinkedListReversal();

        var result = processor.SubReverseList(firstNode, 30, 50);

        Assert.AreEqual("1234567", result.ToString());
    }

    [TestMethod]
    [DataRow(1, 50, "7654321")]
    [DataRow(4, 50, "1237654")]
    public void ReturnWholeReversedListWhenIndexesAreLargerThenList(int leftIndex, int rightIndex, string expectedResult)
    {
        var firstNode = new Node(1);
        var node = firstNode;
        for (var i = 2; i <= 7; i++)
        {
            node.NextNode = new Node(i);
            node = node.NextNode;
        }

        var processor = new SubLinkedListReversal();

        var result = processor.SubReverseList(firstNode, leftIndex, rightIndex);

        Assert.AreEqual(expectedResult, result.ToString());
    }

    [TestMethod]
    [Description("1234567 -> 1234567")]
    public void ReturnSameStringWhenRightIndexIsOneOrLess()
    {
        var firstNode = new Node(1);
        var node = firstNode;
        for (var i = 2; i <= 7; i++)
        {
            node.NextNode = new Node(i);
            node = node.NextNode;
        }

        var processor = new SubLinkedListReversal();

        var result = processor.SubReverseList(firstNode, 0, 1);

        Assert.AreEqual("1234567", result.ToString());
    }
}
