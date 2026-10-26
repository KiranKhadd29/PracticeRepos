using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class TempConvertorProgram
    {
        public static void Main()
        {
            // Store a Fahrenheit temperature
            decimal fahrenheit = 94;

            // Convert it to Celsius
            decimal celsius = (fahrenheit - 32) * 5 / 9;

            // Display the result
            Console.WriteLine($"{fahrenheit}°F is {celsius}°C");
            Console.ReadLine();
        }
    }
}
