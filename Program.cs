using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //1)Write a program that accepts three numbers and computes their sum, product and average

            int firstNum, secondNum, thirdNum, total, product, avg;

            Console.Write("Enter First Number ");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number ");
            secondNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Number ");
            thirdNum = Convert.ToInt32(Console.ReadLine());

            total = firstNum + secondNum;
            product = total * thirdNum;
            avg = total / 3;

            Console.WriteLine("The first number is {0} the Second number is {1} the Third number is {2} and the total is {3}", firstNum, secondNum, thirdNum,total);
            Console.WriteLine("The average is " + avg + " and the product is " + product);

        }
    }
}
