namespace CSharpNewFeatures.Tests;

public abstract class CovariantReturnType
{
    public abstract IEnumerable<string> GetNames();
}

public class MyReturnType : CovariantReturnType
{
    // target type new()
    private readonly List<string> _theList = new();

    // returns a Subclass of IEnumerable
    public override List<string> GetNames()
    {
        return _theList;
    }
}