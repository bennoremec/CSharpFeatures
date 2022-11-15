namespace CSharpNewFeatures.Tests;

public class NullableReferenceTypes
{
    [Fact]
    public void Test()
    {
        Assert.Equal(7, GetNameLength(null, "Presley"));
        Assert.Throws<NullReferenceException>(() => GetNameLength("Presley", null));
    }

    private int GetNameLength(string? firstName, string lastName)
    {
        // return firstName.Length + lastName.Length;
        return (firstName?.Length ?? 0) + lastName.Length;
    }
}