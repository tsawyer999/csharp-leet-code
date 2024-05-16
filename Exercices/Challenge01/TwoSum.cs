namespace Exercices.Challenge01;

public class TwoSum
{
    public int[] FindSum(int[] container, int targetSum)
    {
        if (container.Length < 2)
        {
            return Array.Empty<int>();
        }

        for (var i = 0; i < container.Length; i++)
        {
            for (var j = i + 1; j < container.Length; j++)
            {
                if (container[i] + container[j] == targetSum)
                {
                    return new[] { i, j };
                }
            }
        }

        return Array.Empty<int>();
    }
}