using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question.two
{
    class Program
    {
        static void Main(string[] args)
        {
            //2)Write a program that accepts the radius of a circle and computes both it’s area and circumference.

            double rad;
            
            Console.Write("Enter radius of the circle : ");
            rad = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * rad *rad ;
            double circumference = 2 * Math.PI * rad;

            Console.WriteLine("The Circumference of the circle is : "+circumference);
            Console.WriteLine("The area of a circle is : "+area);
        }
    }
}
