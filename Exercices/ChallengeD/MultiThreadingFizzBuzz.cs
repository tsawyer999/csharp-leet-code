namespace Exercices.ChallengeD;

public static class Program
{
    public static void Main()
    {
        var fizzBuzz = new FizzBuzz(15);

        Task.WaitAll([
            Task.Run(() =>
            {
                fizzBuzz.Fizz(CreateWriteAction("Fizz"));
            }),
            Task.Run(() =>
            {
                fizzBuzz.Buzz(CreateWriteAction("Buzz"));
            }),
            Task.Run(() =>
            {
                fizzBuzz.Fizzbuzz(CreateWriteAction("FizzBuzz"));
            }),
            Task.Run(() =>
            {
                fizzBuzz.Number(CreateWriteIntAction());
            })
        ]);
    }

    private static Action CreateWriteAction(string message)
    {
        return () =>
        {
            Console.WriteLine(message);
        };
    }

    private static Action<int> CreateWriteIntAction()
    {
        return (int value) =>
        {
            Console.WriteLine(value);
        };
    }
}
