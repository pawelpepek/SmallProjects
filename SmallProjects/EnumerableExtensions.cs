namespace SmallProjects;

public static class IEnumerableExtemsions
{
    public static void Print<T>(this IEnumerable<T> items)
        => Console.WriteLine(string.Join(", ", items));
}

