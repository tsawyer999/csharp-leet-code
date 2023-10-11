namespace Exercices;

public class TrapRainWater
{
    public int Calculate(int[] values)
    {
        if (values.Length < 3)
        {
            return 0;
        }

        var sum = 0;
        var leftIndex = 0;
        var rightIndex = values.Length - 1;

        var maxLeft = 0;
        var maxRight = 0;
         
        while (leftIndex != rightIndex)
        {
            var leftValue = values[leftIndex];
            var rightValue = values[rightIndex];
            
            var limit = Math.Min(leftValue, rightValue);
            sum = 0; 

            if (leftValue < rightValue)
            {
                leftIndex++;
            }
            else
            {
                rightIndex--;
            }
        }

        return sum;
    }
}