namespace TreeTraversal;

public class Node<T>
{
    public T Value { get; set; }
    public Node<T> Left { get; }
    public Node<T> Right { get; }
    public Node<T> Parent { get; private set; }

    public Node(T value, Node<T> left, Node<T> right) : this(value, left)
    {
        Right = right;
        if (right != null) right.Parent = this;
    }

    public Node(T value, Node<T> left) : this(value)
    {
        Left = left;
        if (left != null) left.Parent = this;
    }

    public Node(T value) => Value = value;

    public override string ToString() => Value.ToString();
}