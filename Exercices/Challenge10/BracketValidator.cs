namespace Exercices.Challenge10
{
    public class BracketValidator
    {
        private const string OpeningBrackets = "[({";
        private const string ClosingBrackets = "])}";

        private readonly Dictionary<char, char> MatchingBrackets = new()
        {
            { '[', ']' },
            { '{', '}' },
            { '(', ')' }
        };

        public bool IsValid(string? input)
        {
            var stack = new Stack<char>();

            if (input == null)
            {
                return false;
            }

            foreach (var letter in input)
            {
                if (OpeningBrackets.Contains(letter))
                {
                    stack.Push(letter);
                }
                else if (ClosingBrackets.Contains(letter))
                {
                    var openingBracket = stack.Pop();
                    var expectedClosingBracket = MatchingBrackets[openingBracket];

                    if (letter != expectedClosingBracket)
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
