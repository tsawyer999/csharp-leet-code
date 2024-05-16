namespace Exercices.Challenge05
{
    public class LonguestSubstring
    {
        public int Process(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return 0;
            }

            var longuestLength = 0;
            var letters = new List<char>();

            foreach (var letter in value)
            {
                if (letters.Contains(letter))
                {
                    if (letters.Count > longuestLength)
                    {
                        longuestLength = letters.Count;
                    }
                    letters.Clear();
                }
                else
                {
                    letters.Add(letter);
                }

            }
            if (letters.Count > longuestLength)
            {
                longuestLength = letters.Count;
            }

            return longuestLength;
        }
    }
}
