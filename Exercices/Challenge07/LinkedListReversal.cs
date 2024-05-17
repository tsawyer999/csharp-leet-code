namespace Exercices.Challenge07;

public class LinkedListReversal
{
    public Node? SubReverseList(Node root)
    {
        var previousNode = null as Node;
        var currentNode = root;
        Node? nextNode;

        while (currentNode != null)
        {
            nextNode = currentNode.NextNode;

            currentNode.NextNode = previousNode;

            previousNode = currentNode;
            currentNode = nextNode;
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
