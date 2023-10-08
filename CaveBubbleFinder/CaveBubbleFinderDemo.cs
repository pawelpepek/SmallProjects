using BubbleFinder;

namespace CaveBubbleFinder;

public static class CaveBubbleFinderDemo
{
    public static void Run()
    {
        Console.WriteLine("\nCave Bubble Finder Demo");

        string fileName = @"caves.csv";

        var lines = File.ReadLines(fileName).ToArray();

        var finder = new CaveFinder().SetItems(lines)
                                     .SetRange(1, lines.Length - 2);

        finder.Find("Jama Ogra");
        ResultPrinter.Print(finder);


        var finder2 = new BubbleFinder<string, string>(CaveFinder.RowIsThanItem, item => $";;{item.ToUpper()};")
                        .SetItems(lines)
                        .SetRange(1, lines.Length - 2);

        finder2.Find("Agresywna Szczelina");
        ResultPrinter.Print(finder2);


        finder.Find("Żarski Tunel");
        ResultPrinter.Print(finder);


        finder.Find("Nieistniejąca jaskinia");
        ResultPrinter.Print(finder);
    }
}
