namespace Backend;

/*
Improve a block of code as you see fit in C#.
You may make any improvements you see fit, for example:
  - Cleaning up code
  - Removing redundancy
  - Refactoring / simplifying
  - Fixing typos
  - Any other light-weight optimisation
*/
public static class StringFormatter
{
    //Code to improve
    public static string ToCommaSeparatedList(this IEnumerable<string> items, QuoteType? quote = null)
    {
        var quotesToUse = quote ?? QuoteType.NoQuotes;
        return string.Join(", ", items.Select(x => $"{quotesToUse.Start}{x}{quotesToUse.End}"));
    }
}