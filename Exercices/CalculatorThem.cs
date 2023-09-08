using System.Text.RegularExpressions;

namespace Exercices
{
    public class CalculatorThem
    {
        public static int Add(string numbers)
        {
            var result = 0;
            var negativeNumbers = new List<int>();
            if (string.IsNullOrWhiteSpace(numbers))
            {
                return result;
            }

            var delimiter = ",";
            var multipleDelimiters = new List<string>();
            if (numbers.StartsWith("//"))
            {
                var delimiterStartIndex = 1;
                var delimiterEndIndex = numbers.IndexOf("#");
                delimiter = numbers.Substring(delimiterStartIndex + 1,
                    delimiterEndIndex - delimiterStartIndex - 1);
                if (delimiter.StartsWith("["))
                {
                    var i = 0;
                    while (i < delimiter.Length)
                    {
                        if (delimiter[i] == '[')
                        {
                            var startIndex = i;
                            var endIndex = delimiter.IndexOf("]",
                                startIndex);
                            var newDelimiter = delimiter.Substring(startIndex
                                                                   + 1, endIndex - startIndex - 1);
                            multipleDelimiters.Add(newDelimiter);
                            i = endIndex + 1;
                        }
                    }
                }

                numbers = numbers.Substring(delimiterEndIndex + 1);
            }

            if (multipleDelimiters.Any())
            {
                foreach (var del in multipleDelimiters)
                {
                    numbers = numbers.Replace(del, ",");
                }

                delimiter = ",";
            }

            var numbersArray = numbers.Split(delimiter);
            foreach (var strNumber in numbersArray)
            {
                var number = int.Parse(strNumber);
                if (number < 0)
                {
                    negativeNumbers.Add(number);
                }
                else
                {
                    result += number <= 1000 ? number : 0;
                }
            }

            if (negativeNumbers.Any())
            {
                throw new Exception($"Negatives not allowed {string.Join(",", negativeNumbers)}");
            }

            return result;
        }
    }
}