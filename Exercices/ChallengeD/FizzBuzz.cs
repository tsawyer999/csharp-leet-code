namespace Exercices.ChallengeD
{
    public class FizzBuzz
    {
        private int n;
        private volatile int i;
        private object padlock = new();

        public FizzBuzz(int n)
        {
            this.n = n;
            this.i = 1;
        }

        public void Fizz(Action printFizz)
        {
            while (i <= n)
            {
                var ii = i;
                lock (padlock)
                {
                    if (ii % 3 == 0 && ii % 5 != 0)
                    {
                        printFizz();
                        i++;
                    }
                }
            }
        }

        public void Buzz(Action printBuzz)
        {
            while (i <= n)
            {
                var ii = i;
                lock (padlock)
                {
                    if (ii % 3 != 0 && ii % 5 == 0)
                    {
                        printBuzz();
                        i++;
                    }
                }
            }
        }

        public void Fizzbuzz(Action printFizzBuzz)
        {
            while (i <= n)
            {
                var ii = i;
                lock (padlock)
                {
                    if (ii % 3 == 0 && ii % 5 == 0)
                    {
                        printFizzBuzz();
                        i++;
                    }
                }
            }
        }

        public void Number(Action<int> printNumber)
        {
            while (i <= n)
            {
                var ii = i;
                lock (padlock)
                {
                    if (ii % 3 != 0 && ii % 5 != 0)
                    {
                        printNumber(ii);
                        i++;
                    }
                }
            }
        }
    }
}
