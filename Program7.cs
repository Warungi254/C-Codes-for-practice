using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //7)Write a program that accepts distance traveled in metres and the time taken in minutes and then outputs the speed in kilometers per hour (km/h). E.g. if someone enters a distance (in metres) of 500 and a time (in minutes) of 15 the output for speed should be 2 km/h.

            double metres, time, speed;
            
            Console.Write("Enter distance travelled in metres : ");
            metres = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter in minutes : ");
            time = Convert.ToDouble(Console.ReadLine());

            speed = (metres / 1000) / (time / 3600);
            Console.WriteLine("Speed in km/h is "+speed);

        }
    }
}
