// Chapter 2 - Observer Pattern - WeatherStation
// Pg 51: The observer pattern defines a one-to-many relationship between a set of objects. 
// When the state of one object changes, all of its dependents are notified.

using System.Collections.Generic;
using WeatherStation;
using System;

var weatherDataTracker = new WeatherDataTracker();
var subscribers = new List<IObserver<WeatherData>>()
{
    new CurrentConditionsDisplay(),
    new StatisticsDisplay(),
    new ForecastDisplay(),
    new HeatIndexDisplay()
};

foreach (var subscriber in subscribers)
    weatherDataTracker.Subscribe(subscriber);

weatherDataTracker.TrackWeatherData(new WeatherData(80, 65, 30.4F));
weatherDataTracker.TrackWeatherData(new WeatherData(82, 70, 29.2F));
weatherDataTracker.TrackWeatherData(new WeatherData(78, 90, 29.2F));

weatherDataTracker.EndTransmission();