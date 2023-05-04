using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TemperatureConversion
{
    public static class TemperatureUtils
    {
        public static void temperatureConversion()
        {
            Console.WriteLine("Enter the temperature");
            int temperature =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the unit of input temperature F or C");
            string fromUnit=Console.ReadLine();
            Console.WriteLine("Enter the unit of temperature to be converted C or F");
            string toUnit=Console.ReadLine();

            if (fromUnit == "C" && toUnit =="F")
            {
                int tempinFahrenheit = temperature * 9 / 5 + 32;
                Console.WriteLine( "Celsius to Fahrenheit:" +tempinFahrenheit);
            }
            else if (fromUnit == "F" && toUnit == "C")
            {
                int tempinCelsius= (temperature - 32) * 5 / 9;
                Console.WriteLine("Fahrenheit to Celsius:" +tempinCelsius);
            }
            else
            {
                Console.WriteLine("Invalid input units");
            }
        }
    }
}






