namespace Exercices.Challenge06;

public class Palindrome
{
    public bool IsPalindrome(string value)
    {
        var leftIndex = 0;
        var rightIndex = value.Length - 1;

        while (leftIndex < rightIndex)
        {
            while (!((value[leftIndex] >= 65 && value[leftIndex] <= 90) || (value[leftIndex] >= 97 && value[leftIndex] <= 122)))
            {
                leftIndex++;
            }

            while (!((value[rightIndex] >= 65 && value[rightIndex] <= 90) || (value[rightIndex] >= 97 && value[rightIndex] <= 122)))
            {
                rightIndex--;
            }

            if (value[leftIndex] != value[rightIndex])
            {
                if (Math.Abs(value[leftIndex] - value[rightIndex]) != 32)
                {
                    return false;
                }
            }

            leftIndex++;
            rightIndex--;
        }

        return true;
    }
}
