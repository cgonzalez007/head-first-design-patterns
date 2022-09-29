using System;
using System.Collections.Generic;

namespace WeatherStation;

// Following Microsoft IObservable<T> examples 
// https://learn.microsoft.com/en-us/dotnet/api/system.iobservable-1?view=net-6.0
public sealed class WeatherDataTracker : IObservable<WeatherData>
{
    private readonly List<IObserver<WeatherData>> _observers;

    public WeatherDataTracker()
    {
        _observers = new();
    }

    public IDisposable Subscribe(IObserver<WeatherData> observer)
    {
        if (!_observers.Contains(observer))
            _observers.Add(observer);

        return new Unsubscriber(_observers, observer);
    }

    public void TrackWeatherData(WeatherData? weatherData)
    {
        foreach (var observer in _observers)
            if (!weatherData.HasValue)
                observer.OnError(new WeatherDataUnknownException());
            else
                observer.OnNext(weatherData.Value);
    }

    public void EndTransmission()
    {
        foreach (var observer in _observers.ToArray())
            if (_observers.Contains(observer))
                observer.OnCompleted();

        _observers.Clear();
    }

    private class Unsubscriber : IDisposable
    {
        private readonly List<IObserver<WeatherData>> _observers;
        private readonly IObserver<WeatherData> _observer;

        public Unsubscriber(List<IObserver<WeatherData>> observers, IObserver<WeatherData> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}

public class WeatherDataUnknownException : Exception { }
