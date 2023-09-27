namespace Exercices;

public class ContainerWithMostWater
{
    public int Calculate(int[] values)
    {
        if (values.Length == 0)
        {
            return 0;
        }

        var area = 0;
        var limit = Math.Ceiling(values.Length / 2.0);
        for (var leftIndex = 0; leftIndex < limit; leftIndex++)
        {
            for (var rightIndex = leftIndex + 1; rightIndex < values.Length; rightIndex++)
            {
                var leftValue = values[leftIndex];
                var rightValue = values[rightIndex];

                var width = rightIndex - leftIndex + 1;
                var height = Math.Min(leftValue, rightValue);

                var currentArea = width * height; 
                if (currentArea > area)
                {
                    area = currentArea;
                }
            }
        }

        return area;
    }
}
