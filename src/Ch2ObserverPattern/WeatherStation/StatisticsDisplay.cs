using System;

namespace WeatherStation;

public class StatisticsDisplay : WeatherDataReporter, IDisplayElement
{
    private WeatherData _weatherData;
    private float _maxTemp;
    private float _minTemp;
    private float _tempSum;
    private int _numReadings;

    public StatisticsDisplay()
        : base("Statistics Display") { }

    public override void OnNext(WeatherData weatherData)
    {
        _weatherData = weatherData;

        _tempSum += weatherData.Temperature;

        _numReadings++;

        if (weatherData.Temperature > _maxTemp)
            _maxTemp = weatherData.Temperature;

        if (weatherData.Temperature < _minTemp)
            _minTemp = weatherData.Temperature;

        Display();
    }

    public void Display()
        => Console.WriteLine($"Avg/Max/Min temperature = {_tempSum / _numReadings}/{_maxTemp}/{_minTemp}");
}