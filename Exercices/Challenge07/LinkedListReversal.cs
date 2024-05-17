namespace Exercices.Challenge07;

public class LinkedListReversal
{
    public Node? ReverseList(Node root)
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
