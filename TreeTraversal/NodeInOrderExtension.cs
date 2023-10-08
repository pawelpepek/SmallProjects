namespace TreeTraversal;

public static class NodeInOrderExtension
{
    public static IEnumerable<Node<T>> InOrder<T>(this Node<T> current)
    {
        foreach (var node in current.InOrderTraverse())
            yield return node;
    }

    private static IEnumerable<Node<T>> InOrderTraverse<T>(this Node<T> current)
    {
        if (current.Left != null)
        {
            foreach (var left in current.Left.InOrderTraverse())
                yield return left;
        }

        yield return current;

        if (current.Right != null)
        {
            foreach (var right in current.Right.InOrderTraverse())
                yield return right;
        }
    }
}
