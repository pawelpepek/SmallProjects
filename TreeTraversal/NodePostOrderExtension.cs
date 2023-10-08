namespace TreeTraversal;

public static class NodePostOrderExtension
{
    public static IEnumerable<Node<T>> PostOrder<T>(this Node<T> current)
    {
        foreach (var node in current.PostOrderTraverse())
            yield return node;
    }

    private static IEnumerable<Node<T>> PostOrderTraverse<T>(this Node<T> current)
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
