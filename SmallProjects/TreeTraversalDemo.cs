using TreeTraversal;

namespace SmallProjects;

public static class TreeTraversalDemo
{
    public static void Run()
    {
        Console.WriteLine("TreeTraversal Demo");

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

        root.InOrder().Print();
        root.PreOrder().Print();
        root.PostOrder().Print();
    }
}
