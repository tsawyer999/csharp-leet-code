using FluentAssertions;

namespace Exercices.Challenge07;

[TestClass]
public class LinkedListReversalTests
{
    [TestMethod]
    public void Return()
    {
        var firstNode = new Node(1);
        var node = firstNode;
        for (var i = 2; i <= 5; i++)
        {
            node.NextNode = new Node(i);
            node = node.NextNode;
        }

        var processor = new LinkedListReversal();

        var result = processor.SubReverseList(firstNode);

        Assert.AreEqual("54321", result?.ToString());
    }
}
