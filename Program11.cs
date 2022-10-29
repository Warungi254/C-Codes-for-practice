using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //11)Write a program that accepts a number and then outputs it’s square, cube, square root and cube root.

            double number, square, cube, squareRoot, cubeRoot;

            Console.Write("Enter Number : ");
            number = Convert.ToDouble(Console.ReadLine());
            square = number * number;
            cube = number * number * number;
            squareRoot = Math.Ceiling(Math.Sqrt(number));
            cubeRoot = Math.Ceiling(Math.Pow(number, (double)1 / 3));

            Console.WriteLine("The square of the number is {0}, the cube is {1}, the square root is {2} and the cube root is {3}",square, cube, squareRoot,cubeRoot);
                
        }
    }
}
