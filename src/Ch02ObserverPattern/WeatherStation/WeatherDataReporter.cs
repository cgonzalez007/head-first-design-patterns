using System;

namespace WeatherStation
{
    // Following Microsoft IObserver<T> examples
    // https://learn.microsoft.com/en-us/dotnet/api/system.iobserver-1?view=net-6.0
    public abstract class WeatherDataReporter : IObserver<WeatherData>
    {
        private IDisposable? _unsubscriber;
        private string _name;

        protected WeatherDataReporter(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            _name = name;
        }

        public string Name => _name;

        public virtual void Subscribe(IObservable<WeatherData> provider)
        {
            if (provider != null)
                _unsubscriber = provider.Subscribe(this);
        }

        public virtual void OnCompleted()
        {
            Console.WriteLine($"The weather data tracker has completed transmitting data to {Name}.");

            Unsubscribe();
        }

        public virtual void OnError(Exception exception)
            => Console.WriteLine($"{Name}: The weather data cannot be determined. Error: {exception?.Message ?? string.Empty}{Environment.NewLine}{exception?.StackTrace ?? String.Empty}");

        public abstract void OnNext(WeatherData weatherData);

        public virtual void Unsubscribe()
            => _unsubscriber?.Dispose();
    }
}
