namespace BinaryFinder;

public class Range
{
    public int Start { get; }
    public int End { get; }
    public int Center { get; }
    public bool Splittable { get; }

    public Range()
    {
        Start = End = 0;
    }
    public Range(int start, int end)
    {
        Start = start;
        End = end;
        Center = (int)((End - Start) / 2) + Start;
        Splittable = End > Start;
    }
}