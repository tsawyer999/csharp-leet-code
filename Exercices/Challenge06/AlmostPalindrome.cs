namespace Exercices.Challenge06;

public class AlmostPalindrome
{
    public bool IsAlmostPalindrome(string value, int level = 1)
    {
        if (level > 2)
        {
            return false;
        }

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
                    var length = rightIndex - leftIndex;
                    var substring = value.Substring(leftIndex, length);
                    if (IsAlmostPalindrome(substring, level + 1))
                    {
                        return true;
                    }

                    substring = value.Substring(leftIndex + 1, length);
                    if (IsAlmostPalindrome(substring, level + 1))
                    {
                        return true;
                    }


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