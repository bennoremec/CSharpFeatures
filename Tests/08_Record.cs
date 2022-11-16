namespace CSharpNewFeatures.Tests;

public class Record
{
    [Fact]
    public void RecordTest()
    {
        var elvis = new PersonRecord("Elvis", "Presley");
        Assert.Equal(elvis, new PersonRecord("Elvis", "Presley"));
        Assert.NotEqual(elvis, new PersonRecord("Paul", "McCartney"));

        //Deconstructor
        var (firstName, lastname) = elvis;
        Assert.Equal("Elvis", firstName);
    }

    [Fact]
    public void WithTest()
    {
        var elvis = new PersonRecord("Elvis", "Presley");

        Assert.Equal(new PersonRecord("Elvis", "Costello"), elvis with { LastName = "Costello" });
    }
}

public record PersonRecord(string FirstName, string LastName);