namespace CSharpNewFeatures.Tests;

public class InitOnlySetter
{
    [Fact]
    public void Ok()
    {
        var now = new WeatherObservation
        {
            RecordedAt = DateTime.Now,
            TemperatureInCelsius = 20,
            PressureInMillibars = 998.0m
        };

        // Error! CS8852.
        //now.TemperatureInCelsius = 18;
    }

    [Fact]
    public void NotInitialized()
    {
        var now = new WeatherObservation
        {
            RecordedAt = DateTime.Now,
            TemperatureInCelsius = 20
        };

        Assert.Equal(default(decimal), now.PressureInMillibars);
    }
}

public class WeatherObservation
{
    public DateTime RecordedAt { get; init; }
    public decimal TemperatureInCelsius { get; init; }

    public decimal PressureInMillibars { get; init; }
    //ab c# 11, geht auch für Fields
    //public required decimal PressureInMillibars { get; init; }

    public override string ToString() =>
        $"At {RecordedAt} " +
        $"Temp = {TemperatureInCelsius}, with {PressureInMillibars} pressure";
}