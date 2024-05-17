namespace Exercices.Challenge07;

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
