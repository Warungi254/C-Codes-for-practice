using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3)Write a program that accepts the width and length of a rectangle and computes both it’s area and perimeter.
            double width, length, area, perimeter;
            Console.Write("Enter Width : ");
            width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Length : ");
            length = Convert.ToDouble(Console.ReadLine());
            area = length * width;
            perimeter = 2*(length + width);

            Console.WriteLine("The Perimeter is {0} and the area is {1}", perimeter, area);
            
     
        }
    }
}
