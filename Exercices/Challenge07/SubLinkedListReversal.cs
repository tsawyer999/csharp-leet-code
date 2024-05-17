namespace Exercices.Challenge07;

public class SubLinkedListReversal
{
    public Node SubReverseList(Node rootNode, int leftIndex, int rightIndex)
    {
        if (rightIndex < 2)
        {
            return rootNode;
        }

        Node? previousNode = null;
        var currentNode = rootNode;
        Node? nextNode = null;

        var i = 1;
        while (i < leftIndex)
        {
            if (currentNode == null)
            {
                return rootNode;
            }
            previousNode = currentNode;
            currentNode = currentNode.NextNode;
            i++;
        }

        var tailSubList = previousNode;
        var headSubList = currentNode;

        previousNode = null;

        while (i <= rightIndex)
        {
            if (currentNode == null)
            {
                break;
            }
            nextNode = currentNode?.NextNode;

            currentNode.NextNode = previousNode;

            previousNode = currentNode;
            currentNode = nextNode;

            i++;
        }

        if (tailSubList == null)
        {
            headSubList.NextNode = nextNode;
            return previousNode;
        }

        tailSubList.NextNode = previousNode;
        headSubList.NextNode = nextNode;

        return rootNode;
    }
}
