using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 5)Write a program that accepts measurements in cm and converts them into metres. If someone enters 200 for example, the output should take the form;
            200 cm = 2 metres. */

            double cm, metre;
           
            Console.Write("Enter Measurements in cm : ");
            cm = Convert.ToDouble(Console.ReadLine());
            metre = cm / 100;

            Console.WriteLine("The Length in metres is " + metre + "m");
        }
    }
}
