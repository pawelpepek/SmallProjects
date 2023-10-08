using TreeTraversal;

namespace SmallProjects;

public static class TreeTraversalDemo
{
    public static void Run()
    {
        Console.WriteLine("\nTreeTraversal Demo");

        var root = new Node<string>("F",
            new Node<string>("B",
                new Node<string>("A"),
                new Node<string>("D",
                    new Node<string>("C"),
                    new Node<string>("E"))),
            new Node<string>("G",
                null,
                new Node<string>("I",
                    new Node<string>("H"))));

        Console.Write("In-order:\t");
        root.InOrder().Print();

        Console.Write("Pre-order:\t");
        root.PreOrder().Print();

        Console.Write("Post-order:\t");
        root.PostOrder().Print();
    }
}
