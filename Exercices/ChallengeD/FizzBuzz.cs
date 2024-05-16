namespace Exercices.ChallengeD
{
    public class FizzBuzz(int n)
    {
        private volatile int _i = 1;
        private readonly object _padlock = new();

        public void Fizz(Action printFizz)
        {
            while (_i <= n)
            {
                var ii = _i;
                lock (_padlock)
                {
                    if (ii % 3 == 0 && ii % 5 != 0)
                    {
                        printFizz();
                        _i++;
                    }
                }
            }
        }

        public void Buzz(Action printBuzz)
        {
            while (_i <= n)
            {
                var ii = _i;
                lock (_padlock)
                {
                    if (ii % 3 != 0 && ii % 5 == 0)
                    {
                        printBuzz();
                        _i++;
                    }
                }
            }
        }

        public void Fizzbuzz(Action printFizzBuzz)
        {
            while (_i <= n)
            {
                var ii = _i;
                lock (_padlock)
                {
                    if (ii % 3 == 0 && ii % 5 == 0)
                    {
                        printFizzBuzz();
                        _i++;
                    }
                }
            }
        }

        public void Number(Action<int> printNumber)
        {
            while (_i <= n)
            {
                var ii = _i;
                lock (_padlock)
                {
                    if (ii % 3 != 0 && ii % 5 != 0)
                    {
                        printNumber(ii);
                        _i++;
                    }
                }
            }
        }
    }
}
