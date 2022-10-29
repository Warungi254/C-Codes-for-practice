using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_one
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum, secondNum, total;

            Console.Write("Enter First Number ");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number ");
            secondNum = Convert.ToInt32(Console.ReadLine());

            total = firstNum + secondNum;
            Console.WriteLine("The first number is {0} the Second number is {1} and the total is {2}", firstNum, secondNum, total);
                
        }
    }
}
