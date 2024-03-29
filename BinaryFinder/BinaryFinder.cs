﻿namespace BinaryFinder;

public sealed class BinaryFinder<TSource, TSearched> : BinaryFinderBase<TSource, TSearched>
{
    private readonly Func<TSource, TSearched, ElementIs> _rowIsThan;
    private readonly Func<TSearched, TSearched> _itemTransform;

    public BinaryFinder(Func<TSource, TSearched, ElementIs> rowIsThan, Func<TSearched, TSearched> itemTransform)
    {
        _rowIsThan = rowIsThan;
        _itemTransform = itemTransform;
    }

    protected override ElementIs RowIsThan(TSource row, TSearched item) => _rowIsThan(row, item);
    protected override TSearched ItemTransform(TSearched item) => _itemTransform(item);
}
