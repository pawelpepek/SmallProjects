namespace BinaryFinder;

public abstract class BinaryFinderBase<TSource, TSearched>
{
    public int Iterations { get; private set; }
    public TSource Result { get; private set; }
    public IList<TSource> Items { get; set; }
    public Range Range { get; set; } = new();
    private TSearched _searchedItem;

    public BinaryFinderBase<TSource, TSearched> SetItems(IList<TSource> items)
    {
        Items = items;
        return this;
    }

    public BinaryFinderBase<TSource, TSearched> SetRange(int start, int end) => SetRange(new Range(start, end));
    public BinaryFinderBase<TSource, TSearched> SetRange(Range range)
    {
        Range = range;
        return this;
    }

    public TSource Find(TSearched item)
    {
        _searchedItem = ItemTransform(item);

        Iterations = 0;

        Result = Find(Range);

        return Result;
    }

    private TSource Find(Range range)
    {
        Iterations++;

        var center = Items[range.Center];
        var rowIsThan = RowIsThan(center, _searchedItem);

        if (!range.Splittable && rowIsThan != ElementIs.Equals) return default;

        switch (rowIsThan)
        {
            case ElementIs.Equals:
                return center;
            case ElementIs.Less:
                var secondHalf = new Range(range.Center + 1, range.End);
                return Find(secondHalf);
            case ElementIs.Greater:
                var firstHalf = new Range(range.Start, range.Center - 1);
                return Find(firstHalf);
        }

        return default;
    }

    protected virtual TSearched ItemTransform(TSearched item) => item;

    protected abstract ElementIs RowIsThan(TSource row, TSearched item);
}
