using System.ComponentModel.DataAnnotations;

namespace Exercices.Challenge07;

[TestClass]
public class SubLinkedListReversalTests
{
    [TestMethod]
    [Description("1234567 -> 1254367")]
    public void ReverseSubListBetweenLimits()
    {
        var firstNode = new Node(1);
        var node = firstNode;
        for (var i = 2; i <= 7; i++)
        {
            node.NextNode = new Node(i);
            node = node.NextNode;
        }

        var processor = new SubLinkedListReversal();

        var result = processor.SubReverseList(firstNode, 3, 5);

        Assert.AreEqual("1254367", result.ToString());
    }

    [TestMethod]
    [Description("1234567 -> 1234567")]
    public void ReturnSameStringWhenLeftLimitNotReached()
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
    [Description("1234567 -> 1234567")]
    public void ReturnWholeReversedListWhenLimitAreLargerThenList()
    {
        var firstNode = new Node(1);
        var node = firstNode;
        for (var i = 2; i <= 7; i++)
        {
            node.NextNode = new Node(i);
            node = node.NextNode;
        }

        var processor = new SubLinkedListReversal();

        var result = processor.SubReverseList(firstNode, 1, 50);

        Assert.AreEqual("7654321", result.ToString());
    }
}
