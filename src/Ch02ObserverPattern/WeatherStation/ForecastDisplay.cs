using System;

namespace WeatherStation;

public class ForecastDisplay : WeatherDataReporter, IDisplayElement
{
    private WeatherData _lastWeatherData;
    private WeatherData _currentWeatherData;

    public ForecastDisplay()
        : base("Forecast Display") { }

    public override void OnNext(WeatherData weatherData)
    {
        _lastWeatherData = _currentWeatherData;
        _currentWeatherData = weatherData;

        Display();
    }

    public void Display()
    {
        Console.WriteLine("Forecast: ");

        if (_currentWeatherData.Pressure > _lastWeatherData.Pressure)
            Console.WriteLine("Improving weather on the way!");
        else if (_currentWeatherData.Pressure == _lastWeatherData.Pressure)
            Console.WriteLine("More of the same");
        else if (_currentWeatherData.Pressure < _lastWeatherData.Pressure)
            Console.WriteLine("Watch out for cooler, rainy weather");
    }
}

