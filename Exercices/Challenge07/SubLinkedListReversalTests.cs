namespace Exercices.Challenge07;

[TestClass]
public class SubLinkedListReversalTests
{
    [TestMethod]
    public void Return()
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

        Assert.AreEqual("1254367", result?.ToString());
    }
}
