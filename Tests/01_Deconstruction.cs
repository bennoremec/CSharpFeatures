namespace CSharpNewFeatures.Tests;

public class Deconstruction
{
    [Fact]
    public void Deconstruct()
    {
        var person = new Person("Elvis", "Aron", "Presley", "Tupelo", 50000);

        // Deconstruct the person object.
        var (fName, lName, city, _) = person;
        Assert.Equal("Hallo Presley Elvis aus Tupelo!", $"Hallo {lName} {fName} aus {city}!");
    }
}