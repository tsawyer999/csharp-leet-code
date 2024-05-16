namespace Exercices.Challenge03;

public class TrapRainWater
{
    public int Calculate(int[] values)
    {
        if (values.Length < 3)
        {
            return 0;
        }

        var highestIndex = -1;
        var highestValue = 0;
        var water = 0;
        for (var index = 0; index < values.Length; index++)
        {
            if (highestValue < values[index])
            {
                highestValue = values[index];
                highestIndex = index;
            }
        }

        var leftLimit = 0;
        for (var index = 0; index < highestIndex; index++)
        {
            if (leftLimit < values[index])
            {
                leftLimit = values[index];
            }
            else
            {
                water += leftLimit - values[index];
            }
        }

        var rightLimit = 0;
        for (var index = values.Length - 1; index > highestIndex; index--)
        {
            if (rightLimit < values[index])
            {
                rightLimit = values[index];
            }
            else
            {
                water += rightLimit - values[index];
            }
        }

        return water;
    }
}