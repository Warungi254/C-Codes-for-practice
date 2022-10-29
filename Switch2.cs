using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch2
{
    class Program
    {
        static void Main(string[] args)
        {
            char grade;

            Console.Write("Enter the grade you got : ");
            grade = Convert.ToChar(Console.ReadLine());

            switch (grade)
            {
                case 'A': Console.WriteLine("You got a Distinction");
                    break;
                case 'B': Console.WriteLine("You got a Pass");
                    break;
                case 'C': Console.WriteLine("You got a Good");
                    break;
                case 'D': Console.WriteLine("You got a Fail");
                    break;
                case 'E': Console.WriteLine("You got to get a life");
                    break;
                default:Console.WriteLine("Oopsie! Try Again");
                    break;
            }
        }
    }
}
