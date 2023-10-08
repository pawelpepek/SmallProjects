namespace TreeTraversal;

public static class NodePreOrderExtension
{
    public static IEnumerable<Node<T>> PreOrder<T>(this Node<T> current)
    {
        foreach (var node in current.PreOrderTraverse())
            yield return node;
    }

    private static IEnumerable<Node<T>> PreOrderTraverse<T>(this Node<T> current)
    {
        yield return current;

        if (current.Left != null)
        {
            foreach (var left in current.Left.PreOrderTraverse())
                yield return left;
        }

        if (current.Right != null)
        {
            foreach (var right in current.Right.PreOrderTraverse())
                yield return right;
        }
    }
}
