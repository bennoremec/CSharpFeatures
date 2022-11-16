namespace CSharpNewFeatures.Tests;

public class CovariantReturnType
{
    [Fact]
    public void CovRetType()
    {
        BaseClass a = new MyClass();
        var aNames = a.GetNames();

        var b = new MyClass();
        var bNames = b.GetNames();

        Assert.IsType<List<string>>(bNames);
        //Assert.IsType<IEnumerable<string>>(bNames);
    }
}

public abstract class BaseClass
{
    public abstract IEnumerable<string> GetNames();
}

public class MyClass : BaseClass
{
    // target type new()
    private readonly List<string> _theList = new();

    // returns a Subclass of IEnumerable
    public override List<string> GetNames()
    {
        return _theList;
    }
}