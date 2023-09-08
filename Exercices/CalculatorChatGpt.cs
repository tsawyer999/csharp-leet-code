namespace Exercices;

public class CalculatorChatGpt
{
    public static int Add(string values)
    {
        if (String.IsNullOrWhiteSpace(values))
        {
            return 0;
        }

        List<int> negatives = new List<int>();
        int sum = 0;
        string[] delimiters = new string[] { ",", "\n" };

        if (values.StartsWith("//"))
        {
            int delimiterEndIndex = values.IndexOf("#");
            string delimiterString = values.Substring(2, delimiterEndIndex - 2);
            delimiters = delimiterString
                .Split(new string[] { "[", "]" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .ToArray();

            values = values.Substring(delimiterEndIndex + 1);
        }

        string[] numbers = values.Split(delimiters, StringSplitOptions.None);

        foreach (string num in numbers)
        {
            int value = Int32.Parse(num);
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
            string message = "Negatives not allowed ";
            message += String.Join(",", negatives.ToArray());
            throw new Exception(message);
        }

        return sum;
    }
}