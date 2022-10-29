using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*9)Write a program that accepts the weight of a package in grams and then converts it to kilograms and also specifies how many such packages form one kilogram. For example, if the user enters the weight (in grams) of the package as 100, the output should be;
              The weight of the package is 0.1 kilograms.
              It takes 10 such packages to form one kilogram.*/

            double grams, kgs, package;

            Console.Write("Enter weight in grams : ");
            grams = Convert.ToDouble(Console.ReadLine());
            kgs = grams / 1000;
            package = kgs * 100;

            Console.WriteLine("The weight of the package is {0} kilograms ", kgs);
            Console.WriteLine("It takes {0} such packages to form 1 kilogram ", package);
      
        }
    }
}
