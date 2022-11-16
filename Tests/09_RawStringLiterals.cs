using Xunit.Abstractions;

namespace CSharpNewFeatures.Tests;

public class RawStringLiterals
{
    private readonly ITestOutputHelper _testOutputHelper;

    public RawStringLiterals(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void RawStringLiteral()
    {
        _testOutputHelper.WriteLine("***************** Raw string literals from C# 11 *****************");
        //the newline from the first and last line aren't included
        var longMessage = """
    This is a long message.
    It has several lines.
        Some are indented
                more than others.
    Some should start at the first column.
    Some have "quoted text" in them.
    And Some have funky characters like \n or \t without escaping.
    """;

        _testOutputHelper.WriteLine(longMessage);
        _testOutputHelper.WriteLine("******************************************************************");
    }


    [Fact]
    public void RawStringLiteralShort()
    {
        _testOutputHelper.WriteLine("*** Raw string literals from C# 11 ***");
        var longMessage = """Geht's auch kürzer?""";

        _testOutputHelper.WriteLine(longMessage);
        _testOutputHelper.WriteLine("***");
    }
}