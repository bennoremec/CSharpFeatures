namespace CSharpNewFeatures.Tests;

public class UsingDeclaration
{
    [Fact]
    public void Dispose()
    {
        using var d = new MyDisposable();
        //d ist disposed am Ende der Methode
    }


    [Fact]
    public async Task DisposeAsync()
    {
        await using var d = new MyAsyncDisposable();
        //d ist disposed async am Ende der Methode
    }
}

internal class MyDisposable : IDisposable
{
    readonly IDisposable _disposableResource = new MemoryStream();

    public void Dispose()
    {
        _disposableResource.Dispose();
    }
}

internal class MyAsyncDisposable : IAsyncDisposable
{
    readonly IAsyncDisposable _asyncDisposableResource = new MemoryStream();


    public async ValueTask DisposeAsync()
    {
        // do long running task
        await _asyncDisposableResource.DisposeAsync().ConfigureAwait(false);
    }
}