using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionSix
{
    class Program
    {
        static void Main(string[] args)
        {
            //6)Write a program that accepts temperature in degrees Celsius and converts and outputs it in degrees Fahrenheit.

            double degreesCelsius, degreesFarenheit;

            Console.Write("Enter temperature in degrees Celcius : ");
            degreesCelsius = Convert.ToDouble(Console.ReadLine());
            degreesFarenheit = (degreesCelsius * 5) / 9 + 32;

            Console.WriteLine("Degrees in Farenheit is : " + degreesFarenheit);
        }
    }
}
