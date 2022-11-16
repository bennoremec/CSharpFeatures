namespace CSharpNewFeatures.Tests;

public class InitOnlySetter
{
    [Fact]
    public void Ok()
    {
        var now = new WeatherObservation
        {
            RecordedAt = new DateTime(2022, 11, 16),
            TemperatureInCelsius = 20,
            PressureInMillibars = 998.0m
        };

        Assert.Equal(now.RecordedAt, new DateTime(2022, 11, 16));

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
/*    public WeatherObservation()
    {
        RecordedAt = DateTime.Now;
    }*/

    public DateTime RecordedAt { get; init; }
    public decimal TemperatureInCelsius { get; init; }

    public decimal PressureInMillibars { get; init; }
    //ab c# 11, geht auch für Fields
    //public required decimal PressureInMillibars { get; init; }
}