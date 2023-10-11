using System.Text.RegularExpressions;

namespace Exercices;

public class CalculatorThem
{
    public static int Add(string numbers)
    {
        string deliminators = ",";
        int i = -1;
        if (numbers.StartsWith('/'))
        {
            i = 2;
            while (i < numbers.Length && numbers[i] != '#')
            {
                if (numbers[i] == '[' || numbers[i] == ']')
                {
                    ++i;
                    continue;
                }
                deliminators = deliminators + numbers[i];
                ++i;
            }
        }
        var values = numbers.Substring(i + 1).Split(deliminators.ToCharArray(),
            StringSplitOptions.RemoveEmptyEntries);
        var allNumbers = values
            .Select(x => int.Parse(Regex.Match(x, @"-?\d+").Value))
            .Where(x => x < 1000)
            .ToList();
        var negatives = allNumbers.Where(x => x < 0).ToList();
        if (negatives.Any())
        {
            string message = "Negative not allowed " + string.Join(',',
                negatives.Select(n => n.ToString()));
            throw new Exception(message);
        }
        return allNumbers.Sum();
    }
}
