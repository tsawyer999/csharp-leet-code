namespace Exercices.Challenge07;

public class SubLinkedListReversal
{
    private Node? _previousNode;
    private Node? _currentNode;
    private Node? _nextNode;

    private int _index;

    private Node? _tailSubList;
    private Node? _headSubList;

    public Node? SubReverseList(Node rootNode, int leftIndex, int rightIndex)
    {
        if (rightIndex < 2)
        {
            return rootNode;
        }

        if (!DetachHead(rootNode, leftIndex))
        {
            return rootNode;
        }

        ReverseList(rightIndex);

        return AttachHead(rootNode);
    }

    private void ReverseList(int rightIndex)
    {
        _previousNode = null;
        while (_index <= rightIndex)
        {
            if (_currentNode == null)
            {
                break;
            }
            _nextNode = _currentNode?.NextNode;

            _currentNode.NextNode = _previousNode;

            _previousNode = _currentNode;
            _currentNode = _nextNode;

            _index++;
        }
    }

    private bool DetachHead(Node rootNode, int skip)
    {
        _currentNode = rootNode;
        _index = 1;
        while (_index < skip)
        {
            if (_currentNode == null)
            {
                return false;
            }
            _previousNode = _currentNode;
            _currentNode = _currentNode.NextNode;
            _index++;
        }

        _tailSubList = _previousNode;
        _headSubList = _currentNode;

        return true;
    }

    private Node? AttachHead(Node rootNode)
    {
        if (_tailSubList == null)
        {
            _headSubList.NextNode = _nextNode;

            return _previousNode;
        }

        _tailSubList.NextNode = _previousNode;
        _headSubList.NextNode = _nextNode;

        return rootNode;
    }
}
