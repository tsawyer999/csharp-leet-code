using System.Text.RegularExpressions;

namespace Exercices;

public class Calculator
{
    public static int Add(string values)
    {
        if (string.IsNullOrWhiteSpace(values))
        {
            return 0;
        }

        var input = ExtractInput(values);

        var result = input.Sum();

        if (result.NegativeNumbers.Any())
        {
            var toString = string.Join(',', result.NegativeNumbers);
            throw new Exception($"Negatives not allowed {toString}");
        }

        return result.Sum;
    }

    private static Input ExtractInput(string values)
    {
        var regex = new Regex("^//(.*)#");
        var matches = regex.Match(values);

        if (matches.Success)
        {
            var separators = ExtractCustomSeparators(matches.Groups[1].Value);

            return new Input(
                separators,
                values.Substring(matches.Length)
            );
        }

        return new Input(new List<string> { "," }, values);
    }

    private static List<string> ExtractCustomSeparators(string separatorSection)
    {
        var matches = Regex.Matches(separatorSection, "\\[(.*?)\\]", RegexOptions.IgnoreCase);
        var separators = new List<string>();

        if (matches.Count > 0)
        {
            foreach (Match match in matches)
            {
                separators.Add(match.Groups[1].Value);
            }
        }
        else
        {
            separators.Add(separatorSection);
        }

        return separators;
    }
}

public class Input
{
    private readonly List<string> _seperators;
    public string Values { get; }

    public Input(List<string> seperators, string values)
    {
        _seperators = seperators;
        Values = values;
    }

    public List<string> Seperators => _seperators.ToList();

    public Result Sum()
    {
        var result = new Result();
        var values = Values.Split(
            Seperators.ToArray(),
            StringSplitOptions.None);
        foreach (var value in values)
        {
            if (!int.TryParse(value, out var convertedValue))
            {
                continue;
            }

            switch (convertedValue)
            {
                case < 0:
                    result.NegativeNumbers.Add(value);
                    break;

                case < 1000:
                    result.Sum += convertedValue;
                    break;
            }
        }

        return result;
    }
}

public class Result
{
    public int Sum { get; set; }
    public List<string> NegativeNumbers { get; } = new();
}