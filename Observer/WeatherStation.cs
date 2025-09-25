using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    // Sujeto
    public class WeatherStation
    {
        private List<IObserver> observers = new List<IObserver>();
        private int temperature;

        public void Attach(IObserver observer) => observers.Add(observer);
        public void Detach(IObserver observer) => observers.Remove(observer);

        public void SetTemperature(int temp)
        {
            temperature = temp;
            Notify();
        }

        private void Notify()
        {
            foreach (var obs in observers)
                obs.Update(temperature);
        }
    }

    // Observador
    public interface IObserver
    {
        void Update(int temperature);
    }

    // Observadores concretos
    public class MobileApp : IObserver
    {
        public void Update(int temperature) =>
            Console.WriteLine($"[Mobile] Nueva temperatura: {temperature}°C");
    }

    public class WebApp : IObserver
    {
        public void Update(int temperature) =>
            Console.WriteLine($"[Web] Nueva temperatura: {temperature}°C");
    }

}