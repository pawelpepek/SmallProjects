namespace TreeTraversal;

public static class NodeExtensions
{
    public static IEnumerable<Node<T>> InOrder<T>(this Node<T> current)
    {
        foreach (var node in current.InOrderTraverse())
            yield return node;
    }

    public static IEnumerable<Node<T>> PreOrder<T>(this Node<T> current)
    {
        foreach (var node in current.PreOrderTraverse())
            yield return node;
    }

    public static IEnumerable<Node<T>> PostOrder<T>(this Node<T> current)
    {
        foreach (var node in current.PostOrderTraverse())
            yield return node;
    }
}
