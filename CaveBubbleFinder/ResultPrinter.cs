using BubbleFinder;

namespace CaveBubbleFinder;

public static class ResultPrinter
{
    private static int ResultIndex = 0;

    public static void Print<TSource, TSearched>(BubbleFinderBase<TSource, TSearched> finder)
    {
        PrintResult(finder.Result?.ToString());
        PrintIterations(finder.Iterations);
    }

    private static void PrintResult(string result)
        => Console.WriteLine($"Result nr {++ResultIndex}: {result}");
    private static void PrintIterations(int iterations)
        => Console.WriteLine($"\tIterations nr {ResultIndex}: {iterations}");
}
