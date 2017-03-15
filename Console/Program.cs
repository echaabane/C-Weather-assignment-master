using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAssignment;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherDataServiceFactory obj = WeatherDataServiceFactory.Instance;                     //get instance of weather data service factory

            Location location = new Location();                                                     //create location object
            location.city = "London";

            var tmp = obj.GetWeatherDataService(location);
            System.Console.WriteLine("Country: " + tmp.Sys.Country.ToString() + "\nCity: " + tmp.Name.ToString() + "\nTempreture: " + tmp.Main.Temp.ToString() + " (Kelvin)" + "\nWind Speed: " + tmp.Wind.Speed.ToString() + "\nPressure: " + tmp.Main.Pressure.ToString() + " (Kelvin)" + "\nHumidity: " + tmp.Main.Humidity.ToString());
            System.Console.Read();
        }
    }
}
