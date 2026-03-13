using System.Text;

namespace Backend
{
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
        public static string ToCommaSeparatedList(this string[] items, QuoteType? quote = null)
        {
            var quotesToUse = quote ?? QuoteType.NoQuotes;
            if (items.Length == 0) return string.Empty;
            var qry = new StringBuilder($"{quotesToUse.Start}{items[0]}{quotesToUse.End}");
            for (var i = 1; i < items.Length; i++)
            {
                qry.Append($", {quotesToUse.Start}{items[i]}{quotesToUse.End}");
            }

            return qry.ToString();
        }
    }
}