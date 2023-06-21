using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Converting_back__and_forth
{
    internal class Conversion{

        public void conversionCelsusToFahrenheit(double value1) {
            double result = (value1 * 1.8) + 32;
            Console.WriteLine("the conversion Celsus to Fahrenheit is= " + result);
        }

        public void conversionFahrenheitToCelsus(double value2)
        {
            double result = (value2 - 32) * 0.555;
            Console.WriteLine("the conversion Fahrenheit to Celsus is= " + result);
        }
    }
}
