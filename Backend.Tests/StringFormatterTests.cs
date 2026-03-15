namespace Backend.Tests;

public class Tests
{
    [Test]
    public void ShouldBeAbleToFormatArrayWithProvidedSeparatorAndQuotes()
    {
        var input = new[]{"apples", "oranges", "mangoes"};

        var actual = input.ToCommaSeparatedList(QuoteType.DoubleQuotes);
        
        Assert.That(actual, Is.EqualTo("\"apples\", \"oranges\", \"mangoes\""));
    }

    [Test]
    public void ShouldAllowListOfStringsToBeFormattedWithProvidedSeparatorAndQuotes()
    {
        List<string> input = ["apples", "oranges", "mangoes"];

        var actual = input.ToCommaSeparatedList(QuoteType.DoubleQuotes);
        
        Assert.That(actual, Is.EqualTo("\"apples\", \"oranges\", \"mangoes\""));
    }
    
    
    [Test]
    public void ShouldAllowCustomQuotes()
    {
        var input = new[]{"apples", "oranges", "mangoes"};

        var actual = input.ToCommaSeparatedList(new ("\"", "'"));
        
        Assert.That(actual, Is.EqualTo("\"apples', \"oranges', \"mangoes'"));
    }
    
    [Test]
    public void ShouldNotPutAnyQuotesByDefault()
    {
        var input = new[]{"apples", "oranges", "mangoes"};

        var actual = input.ToCommaSeparatedList();
        
        Assert.That(actual, Is.EqualTo("apples, oranges, mangoes"));
    }
    
    [Test]
    public void ShouldBeAbleToHandleEmptyArray()
    {
        string[] input = [];

        var actual = input.ToCommaSeparatedList();
        
        Assert.That(actual, Is.EqualTo(string.Empty));
    }
    
    [Test]
    public void ShouldBeAbleToHandleJustOneItem()
    {
        string[] input = ["one item"];

        var actual = input.ToCommaSeparatedList();
        
        Assert.That(actual, Is.EqualTo("one item"));
    }
    
    [Test]
    public void ShouldBeAbleToHandleJustOneItemWithQuotes()
    {
        string[] input = ["one item"];

        var actual = input.ToCommaSeparatedList(QuoteType.SingleQuotes);
        
        Assert.That(actual, Is.EqualTo("'one item'"));
    }
    
}