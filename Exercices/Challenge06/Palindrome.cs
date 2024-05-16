namespace Exercices.Challenge06;

public class Palindrome
{
    public bool IsPalindrome(string value)
    {
        var leftIndex = 0;
        var rightIndex = value.Length - 1;

        while (leftIndex < rightIndex)
        {
            while (!IsAlpha(value[leftIndex]))
            {
                leftIndex++;
            }

            while (!IsAlpha(value[rightIndex]))
            {
                rightIndex--;
            }

            if (value[leftIndex] != value[rightIndex])
            {
                if (!IsSameChar(value[leftIndex], value[rightIndex]))
                {
                    return false;
                }
            }

            leftIndex++;
            rightIndex--;
        }

        return true;
    }

    private bool IsAlpha(char c)
    {
        if (c < 65)
        {
            return false;
        }

        if (c <= 90)
        {
            return true;
        }

        if (c < 97)
        {
            return false;
        }

        if (c <= 122)
        {
            return true;
        }

        return false;
    }

    private bool IsSameChar(char l, char r)
    {
        var diff = l - r;
        return diff is 32 or -32;
    }
}
