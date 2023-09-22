namespace Exercices;

public class SumTwoStrings
{
    public static string SumStrings(string a, string b)
    {
        string shortString;
        string longString;

        var result = "";
        var retainer = 0;

        a = a.TrimStart('0');
        b = b.TrimStart('0');

        if (a.Length > b.Length)
        {
            shortString = b;
            longString = a;
        }
        else
        {
            shortString = a;
            longString = b;

        }

        var delta = longString.Length - shortString.Length;
        int i;
        for (i = shortString.Length - 1; i >= 0; i--)
        {
            if (!int.TryParse(shortString[i].ToString(), out var value1))
            {
                return "-1";
            }
            if (!int.TryParse(longString[i + delta].ToString(), out var value2))
            {
                return "-1";
            }

            var sum = Convert.ToString(value1 + value2 + retainer);
            retainer = sum.Length > 1 ? 1 : 0;

            result = sum[^1] + result;
        }

        i = delta - 1;
        while (i >= 0)
        {
            if (!int.TryParse(longString[i].ToString(), out var value))
            {
                return "-1";
            }

            var sum = Convert.ToString(value + retainer);
            retainer = sum.Length > 1 ? 1 : 0;

            result = sum[^1] + result;

            i--;
        }

        if (retainer > 0)
        {
            result = retainer + result;
        }

        return result == "" ? "0" : result;
    }
}