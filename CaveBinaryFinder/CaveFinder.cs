using BinaryFinder;

namespace CaveBinaryFinder;

public class CaveFinder : BinaryFinderBase<string, string>
{
    public static ElementIs RowIsThanItem(string row, string item)
    {
        var start = row.IndexOf(";;");
        var rowTextToCompare = row.Substring(start);

        if (rowTextToCompare.StartsWith(item)) return ElementIs.Equals;

        return (ElementIs)string.Compare(rowTextToCompare, item);
    }

    protected override ElementIs RowIsThan(string row, string item) => RowIsThanItem(row, item);
    protected override string ItemTransform(string item) => $";;{item.ToUpper()};";
}
