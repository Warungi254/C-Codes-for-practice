using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch3
{
    class Program
    {
        static void Main(string[] args)
        {
            char grade;

            Console.Write("Enter the grade you got : ");
            grade = Convert.ToChar(Console.ReadLine());

            switch (Char.ToLower(grade))
            {
                case 'a':Console.WriteLine("You got a Distinction ");
                    break;
                case 'b': Console.WriteLine("You got a Pass");
                    break;
                case 'c': Console.WriteLine("You got a Good");
                    break;
                case 'd': Console.WriteLine("You got a Fail");
                    break;
                case 'e': Console.WriteLine("Get a life my love");
                    break;
                default: Console.WriteLine("Oopsie! Darling don't try that again");
                    break;
            }

        }
    }
}
