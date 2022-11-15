namespace CSharpNewFeatures.Tests;

public class Range
{
    [Fact]
    public void Get2And3()
    {
        //c#8 Range operator
        Assert.Equal(new[] { "Maria", "Hans" }, GetLast2People(2..4));
    }

    [Fact]
    public void GetLast2()
    {
        //c#8 Range operator
        Assert.Equal(new[] { "Maria", "Hans" }, GetLast2People(^2..));
    }


    public IEnumerable<string> GetLast2People(System.Range range)
    {
        var people = new[] { "Peter", "Marcus", "Maria", "Hans" };

        foreach (var name in people[range])
        {
            yield return name;
        }
    }
}