using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprograms
{
    internal class Temperatureconversion
    {
        public static void temperatureconversion()
        {
            double celsius, fahrenheit;
            Console.WriteLine("Enter Temperature in Fahrenheit : ");
            Console.WriteLine("Enter Temperature in celsius:");
            fahrenheit = Convert.ToDouble(Console.ReadLine());
            celsius = Convert.ToDouble(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5 / 9;
            fahrenheit=(celsius *9/5) +32;
            Console.WriteLine("Temperature in Celsius : " + celsius);
            Console.WriteLine("Temperature in fahrenheit : " + fahrenheit);
            Console.ReadLine();
        }
    }
}
