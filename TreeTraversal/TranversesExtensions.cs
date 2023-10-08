namespace TreeTraversal;

public static class TraversesExtensions
{
    public static IEnumerable<Node<T>> InOrderTraverse<T>(this Node<T> current)
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

    public static IEnumerable<Node<T>> PreOrderTraverse<T>(this Node<T> current)
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

    public static IEnumerable<Node<T>> PostOrderTraverse<T>(this Node<T> current)
    {
        if (current.Left != null)
        {
            foreach (var left in current.Left.PostOrderTraverse())
                yield return left;
        }

        if (current.Right != null)
        {
            foreach (var right in current.Right.PostOrderTraverse())
                yield return right;
        }

        yield return current;
    }
}
