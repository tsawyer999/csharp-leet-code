namespace Exercices.Challenge07;

public class LinkedListReversal
{
    public Node? SubReverseList(Node root)
    {
        var previousNode = null as Node;
        var node = root;
        Node? nextNode;

        while (node != null)
        {
            nextNode = node.NextNode;
            node.NextNode = previousNode;
            previousNode = node;
            node = nextNode;
        }

        return previousNode;
    }
}

public class Node(int value)
{
    public int Value { get; set; } = value;
    public Node? NextNode { get; set; }

    public override string ToString()
    {
        return NextNode != null
            ? Value + NextNode.ToString()
            : Value.ToString();
    }
}
