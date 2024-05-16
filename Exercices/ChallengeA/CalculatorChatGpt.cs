namespace Exercices.ChallengeA;

public class CalculatorChatGpt
{
    public static int Add(string values)
    {
        if (string.IsNullOrWhiteSpace(values))
        {
            return 0;
        }

        var negatives = new List<int>();
        var sum = 0;
        var delimiters = new[] { ",", "\n" };

        if (values.StartsWith("//"))
        {
            var delimiterEndIndex = values.IndexOf("#");
            var delimiterString = values.Substring(2, delimiterEndIndex - 2);
            delimiters = delimiterString
                .Split(["[", "]"], StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .ToArray();

            values = values.Substring(delimiterEndIndex + 1);
        }

        var numbers = values.Split(delimiters, StringSplitOptions.None);

        foreach (var num in numbers)
        {
            var value = int.Parse(num);
            if (value < 0)
            {
                negatives.Add(value);
            }
            else if (value <= 1000)
            {
                sum += value;
            }
        }

        if (negatives.Count > 0)
        {
            var message = "Negatives not allowed ";
            message += string.Join(",", negatives.ToArray());
            throw new Exception(message);
        }

        return sum;
    }
}