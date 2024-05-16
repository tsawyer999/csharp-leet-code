namespace Exercices.ChallengeD
{
    public static class Program
    {
        public static void Main()
        {
            Action printFizz = () =>
            {
                Console.WriteLine("Fizz");
            };
            Action printBuzz = () =>
            {
                Console.WriteLine("Buzz");
            };
            Action printFizzBuzz = () =>
            {
                Console.WriteLine("FizzBuzz");
            };
            Action<int> printNumber = (int value) =>
            {
                Console.WriteLine(value);
            };

            var fizzBuzz = new FizzBuzz(15);

            Task.WaitAll([
                Task.Run(() =>
                {
                    fizzBuzz.Fizz(printFizz);
                }),
                Task.Run(() =>
                {
                fizzBuzz.Buzz(printBuzz);
                }),
                Task.Run(() =>
                {
                fizzBuzz.Fizzbuzz(printFizzBuzz);
                }),
                Task.Run(() =>
                {
                fizzBuzz.Number(printNumber);
                })
            ]);
        }
    }
}
