﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int points;
            Console.Write("Enter the points the student got - > ");
            points = Convert.ToInt32(Console.ReadLine());

            switch (points)
            {
                case '4': Console.WriteLine("The student got a Distinction ");
                    break;
                case '3': Console.WriteLine("The student got a Credit.");
                    break;
                case '2': Console.WriteLine("The student got a Pass.");
                    break;
                case '1': Console.WriteLine("The student got a Fail.");
                    break;
                default: Console.WriteLine(points + " not valid! Points can only be between 1 and 4.\a\a\a");
                    break;
            }
            Console.WriteLine("Have yourself a lovely day.");
        }
    }
}
