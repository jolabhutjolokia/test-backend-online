namespace Backend;

public class QuoteType(string start, string? end = null)
{
    public string Start => start;
    public string End => end ?? start;

    public static readonly QuoteType NoQuotes = new("");
    public static readonly QuoteType SingleQuotes = new("'");
    public static readonly QuoteType CurlySingleQuotes = new("‘", "’");
    public static readonly QuoteType DoubleQuotes = new("\"");
    public static readonly QuoteType CurlyDoubleQuotes = new("“", "”");
}