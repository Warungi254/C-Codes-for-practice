using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace And
{
    class Program
    {
        static void Main(string[] args)
        {
            double marks;

            Console.Write("enter your marks : ");
            marks = Convert.ToDouble(Console.ReadLine());

            if (marks >= 0 && marks <= 100)
            {
                Console.Write(marks + " is a valid mark");
            } else
            {
                Console.Write(marks + " is an invalid mark");
            }
            Console.ReadKey();
        }
    }
}
