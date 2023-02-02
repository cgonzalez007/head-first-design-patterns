using System;

namespace WeatherStation;

public class CurrentConditionsDisplay : WeatherDataReporter, IDisplayElement
{
    private WeatherData _weatherData;

    public CurrentConditionsDisplay()
        : base("Current Conditions Display") { }

    public override void OnNext(WeatherData weatherData)
    {
        _weatherData = weatherData;

        Display();
    }

    public void Display()
        => Console.WriteLine($"Current conditions: {_weatherData.Temperature} F degrees and {_weatherData.Humidity}% humidity");
}
