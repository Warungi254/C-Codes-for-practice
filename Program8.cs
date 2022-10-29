using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8)Write a program that accepts measurements in kilometers and the converts and displays them in metres.E.g. if someone enters 0.4(kilometers) the output should take the form 0.4 kilometers = 400 metres

            double km, metres;

            Console.Write("Enter Measurements in Kilometres : ");
            km = Convert.ToDouble(Console.ReadLine());
            metres = km * 1000;

            Console.WriteLine("The measurements is {0} km = {1} metres",km, metres);

        }
    }
}
