namespace CSharpNewFeatures.Tests;

public class RangeTest
{
    [Fact]
    public void Get2And3()
    {
        //c#8 Range operator
        Assert.Equal(new[] { "Maria", "Hans" }, GetPeople(2..4));
    }

    [Fact]
    public void GetLast2()
    {
        //c#8 Range operator
        Assert.Equal(new[] { "Maria", "Hans" }, GetPeople(^2..));
    }


    public IEnumerable<string> GetPeople(Range range)
    {
        var people = new[] { "Peter", "Marcus", "Maria", "Hans" };

        foreach (var name in people[range])
        {
            yield return name;
        }
    }

    [Fact]
    public async Task AsyncForeach()
    {
        var i = 0;
        await foreach (var name in GetPeopleAsnyc(..3))
        {
            i++;
            Assert.True(new[] { "Peter", "Marcus", "Maria" }.Contains(name), $"Name nicht Peter, Marcus oder Maria sondern {name}");
        }

        Assert.Equal(3, i);
    }

    public async IAsyncEnumerable<string> GetPeopleAsnyc(Range range)
    {
        var people = new[] { "Peter", "Marcus", "Maria", "Hans" };

        foreach (var name in people[range])
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            yield return name;
        }
    }
}