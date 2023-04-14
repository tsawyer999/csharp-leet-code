namespace Exercices
{
    public class TwoSum
    {
        public int[] FindSum(int[] container, int sum)
        {
            if (container.Length < 2)
            {
                return Array.Empty<int>();
            }
            
            for (var i = 0; i < container.Length; i++)
            {
                for (var j = i + 1; j < container.Length; j++)
                {
                    if (container[i] + container[j] == sum)
                    {
                        return new[] { i, j };
                    }
                }
            }
            
            return Array.Empty<int>();
        }
    }
}
