namespace Exercices;

public class TrapRainWater
{
    public int Calculate(int[] values)
    {
        if (values.Length < 3)
        {
            return 0;
        }
        
        var water = 0;

        for (var i = 0; i < values.Length; i++)
        {
            var value = values[i];
            var leftLimit = GetLeftLimit(i, values);
            var rightLimit = GetRightLimit(i, values);
            var limit = leftLimit < rightLimit ? leftLimit : rightLimit;

            if (limit - value > 0)
            {
                water += limit - value;    
            }
        }

        return water;
    }

    private int GetLeftLimit(int index, int[] values)
    {
        var leftLimit = 0;
        for (var i = 0; i < index; i++)
        {
            var value = values[i];
            if (leftLimit < value)
            {
                leftLimit = value;
            }
        }

        return leftLimit;
    }

    private int GetRightLimit(int index, int[] values)
    {
        var rightLimit = 0;
        for (var i = index + 1; i < values.Length; i++)
        {
            var value = values[i];
            if (rightLimit < value)
            {
                rightLimit = value;
            }
        }

        return rightLimit;
    }
}