using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WeatherStation station = new WeatherStation();
            station.Attach(new MobileApp());
            station.Attach(new WebApp());

            station.SetTemperature(25);
            station.SetTemperature(30);

        }
    }
}
