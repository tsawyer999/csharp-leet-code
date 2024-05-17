namespace Exercices.Challenge04;

public class TypedOut
{
    public bool Process(string value1, string value2)
    {
        var result1 = TypeIt(value1);
        var result2 = TypeIt(value2);

        return result1 == result2;
    }

    private string TypeIt(string value)
    {
        var stack = new Stack<char>();

        foreach (var letter in value)
        {
            if (letter == '#')
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            else
            {
                stack.Push(letter);
            }
        }

        return string.Join("", stack.Reverse());
    }
}
