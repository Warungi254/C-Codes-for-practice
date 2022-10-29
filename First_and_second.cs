using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_and_second
{
    class Program
    {
        static void Main(string[] args)
        {
            //use if esle to display a coondition between the first and second number

            double first, second;

            Console.Write("Enter first number : ");
            first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            second = Convert.ToInt32(Console.ReadLine());

            if (first > second) {
                Console.WriteLine("The first number {0} is larger than the second number {1}", first, second);
                Console.WriteLine("You are doing a great job Carol");
            } else
            {
                Console.WriteLine("The second number {0} is smaller than the first number {1}", second , first);
            }
        }
    }
}
