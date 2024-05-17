namespace Exercices.Challenge07;

public class SubLinkedListReversal
{
    public Node? SubReverseList(Node rootNode, int leftIndex, int rightIndex)
    {
        var previousNode = null as Node;
        var currentNode = rootNode;
        Node? nextNode = null as Node;
        Node? leftNode1;
        Node? leftNode2;
        
        var i = 1;
        while (i < leftIndex)
        {
            previousNode = currentNode;
            currentNode = currentNode.NextNode;
            i++;
        }

        leftNode1 = previousNode;
        leftNode2 = currentNode;

        previousNode = null;

        while (i <= rightIndex)
        {
            nextNode = currentNode.NextNode;

            currentNode.NextNode = previousNode;

            previousNode = currentNode;
            currentNode = nextNode;

            i++;
        }

        leftNode1.NextNode = previousNode;
        leftNode2.NextNode = nextNode;

        return rootNode;
    }
}
