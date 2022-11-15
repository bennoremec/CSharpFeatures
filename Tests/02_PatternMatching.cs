namespace CSharpNewFeatures.Tests;

public class PatternMatching
{
    [Fact]
    public void TypeMatching()
    {
        object obj = new Person("Fritz", "Markus", "Müller", "Luzern", 5000);

        if (obj is Person person)
        {
            Assert.Equal("Fritz", person.FirstName);
        }
        else
        {
            Assert.Fail("obj ist nicht vom Typ Person");
        }
    }

    [Fact]
    public void RelationalMatching()
    {
        var fritz = new Person("Fritz", "Markus", "Müller", "Luzern", 11000);
        var xaver = new Person("Xaver", "", "Arnold", "Schattdorf", 500);

        Assert.Equal("Reicher Luzerner", GetPersonGroup(fritz));
        Assert.Equal("Armer Schattdorfer", GetPersonGroup(xaver));
    }

    private static string GetPersonGroup(Person person)
    {
        return person switch
        {
            { City: "Luzern", Lohn: > 10000m } => "Reicher Luzerner",
            { City: "Schattdorf", Lohn: < 1000m } => "Armer Schattdorfer",
            _ => "Übrige"
        };
    }
}