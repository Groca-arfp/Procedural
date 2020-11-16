using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celcius_to_fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double f, c;

            Console.WriteLine("Saisissez la valeur en Celsius:");
            c = Convert.ToDouble(Console.ReadLine());

            f = c * 9 / 5 + 32;

            Console.WriteLine(c + "°C en  Fahrenheit est: " + f + " °F ");

            Console.WriteLine("Saisissez la valeur en Fahrenheit:");
            f = Convert.ToDouble(Console.ReadLine());

            c = (f - 32) * 5 / 9;

            Console.WriteLine(f + "°F en Celsius est: " + c + " °C ");
            Console.ReadLine();
        }
    }
}
