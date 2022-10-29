using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questin_4
{
    class Program
    {
        static void Main(string[] args)
        {
           // 4)	Write a program that computes the area of a right-angled triangle.

            double a, b, area;

            Console.Write("Enter a : ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter b : ");
            b = Convert.ToDouble(Console.ReadLine());
            area = (a * b) / 2;

            Console.WriteLine("The area is " + area);
        }
    }
}
